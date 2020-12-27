### Source Map Sharp

## About

This is a direct rewrite (meaning, the goal was not to write 'idiomatic' F# code, but to resemble inital JS code as close as possible)

### Files - status

1. `ArraySet` - Done & tested
2. `Base64` - Done & tested
3. `Base64-vlq` - Done & tested
4. `binary-search` - Not done, probably won't need
5. `mapping-list` - Done, not tested specifically, maybe can be tested via SourceMapGenerator
6. `mapping.wasm` - Not done, probably won't need
7. `read-wasm-browser` - Not done, probably won't need
8. `read-wasm` - Not done, probably won't need
9. `source-map-consumer` - Not done, Don't know if will need it or not at the moment
10. `source-map-generator` - Done except the `consumer` parts, not tested
11. `source-node` - Done  except the `consumer` parts, not tested
12. `url-browser` - Not done, probably won't need
13. `url` - Not done, need help
14. `util` - Done partially, only what's needed, `url`-related stuff not done
15. `wasm` - Not done, probably won't need

#### "SourceMapConsumer"-related stuff

Not done at the moment: 

1. SourceNode `fromStringWithSourceMap` function
2. SourceMapGenerator `fromSourceMap` function
3. SourceMapConsumer module


### Help needed

1. `util.join`
2. `util.relative`
3. Tests for `SourceMapNode`, `SourceMapGenerator`
4. Decisions on `wasm` stuff
5. Documentation & usage examples
