dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml "https://app.cvat.ai/api/schema/?format=openapi-json"

# Fix: Add top-level security and servers (spec only has per-operation security)
python3 -c "
import yaml

with open('openapi.yaml') as f:
    spec = yaml.safe_load(f)

# Add servers
spec['servers'] = [{'url': 'https://app.cvat.ai'}]

# Add top-level security (use bearer token)
spec['security'] = [{'accessTokenAuth': []}]

# Remove endpoints that return bare enums (incompatible with generated FromJson)
if '/api/cloudstorages/{id}/status' in spec.get('paths', {}):
    del spec['paths']['/api/cloudstorages/{id}/status']

import json
with open('openapi.yaml', 'w') as f:
    json.dump(spec, f, indent=2)
"

autosdk generate openapi.yaml \
  --namespace CVAT \
  --clientClassName CVATClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --exclude-deprecated-operations
