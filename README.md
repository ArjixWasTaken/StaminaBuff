## StaminaBuff

## Getting started

First of all, you need to modify `run.ps1` so it knows where the game files are. </br>
Look for the `Config` section, mine is
```powershell
##### <Config>
$gameName = "Lethal Company"
$gameRoot = "C:\Games\$gameName"
$pluginsRoot = "${gameRoot}\BepInEx\plugins"
##### </Config>
```
You will most likely only have to edit `$gameRoot`, as the other values won't change.

Finally, visit the [BepInEx](https://docs.bepinex.dev/articles/dev_guide/plugin_tutorial/3_logging.html), [HarmonyX](https://github.com/BepInEx/HarmonyX/wiki) and [LethalWiki](https://lethal.wiki/#/) docs to learn the next steps!

---
### Usage

Two configurations are provided, `Build` and `Run`.

`Build`:
```powershell
. run.ps1
```

`Run`:
```powershell
$env:RUN=1
. run.ps1
```
