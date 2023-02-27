# Space-Warp-Example-Mod-Template
An example mod template for Space Warp


## `modinfo.json`

### `mod_id`

The ID of the mod, should be the same as the folder name for the mod

### `author`

Who wrote the mod

### `name`

The name for the mod

### `description`

A short description for the mod

### `version`

The mod version

### `dependencies`


#### Dependency structure

##### `id`

The mod ID of the dependency

##### `version`

A structure with a `min` and `max` semantic version field, any field in there can be replaced with `*`, so like `1.*` or `*` are valid versions

### `ksp2_version`

See `version` but for KSP2


### `config`

Where the generated config files for the mod will go

### `bin`

Where DLLs necessary for the mod will go, you can also compile your mod and put it in this folder

### `src`

The source folder of the mod, gets compiled when changed, and cached


### `assets`

The assets folder of the mod, assets should go here to be automatically loaded, as of right now only bundles can go in here

