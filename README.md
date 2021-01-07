# Source Map Sharp

## About

This is a direct rewrite (meaning, the goal was not to write 'idiomatic' F# code, but to resemble inital JS code as close as possible) of source map generation tool https://github.com/mozilla/source-map

Which is originally written in JS. The initial purpose is to use it with https://github.com/fable-compiler/Fable project


See https://github.com/fable-compiler/Fable/issues/2166 - "Bring back source map support"

P.S. If you're a user that needs netstandard2.0 (as opposed to current netstandard2.1), please file an issue.
### Files - status

1. `ArraySet` - Done & tested
2. `Base64` - Done & tested
3. `Base64-vlq` - Done & tested
4. `binary-search` - Not done, probably won't need
5. `mapping-list` - Done, not tested specifically, coverage shows 95% via other tessts
6. `mapping.wasm` - Not done, probably won't need
7. `read-wasm-browser` - Not done, probably won't need
8. `read-wasm` - Not done, probably won't need
9. `source-map-consumer` - Not done, Don't know if will need it or not at the moment
10. `source-map-generator` - Done except the `consumer` parts, tested except `consumer` parts
11. `source-node` - Done except the `consumer` parts, tested partially
12. `url-browser` - Not done, probably won't need
13. `url` - Not done, probably won't need
14. `util` - Done partially, what's needed
15. `wasm` - Not done, probably won't need

#### "SourceMapConsumer"-related stuff

Not done at the moment: 

1. SourceNode `fromStringWithSourceMap` function
2. SourceMapGenerator `fromSourceMap` function
3. SourceMapConsumer module


### Help needed

1. Tests for `SourceMapNode`
2. Documentation & usage examples
