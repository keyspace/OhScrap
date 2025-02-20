---
permalink: /ManualInstallation.html
title: Manual Installation
description: the flat-pack Kiea instructions, written in Kerbalese, unusally present
tags: installation,directions,page,kerbal,ksp,zer0Kerbal,zedK
---
<!-- ManualInstallation.md v1.1.8.1
OhScrap! (OS)
created: 01 Oct 2019
updated: 29 Jul 2022 -->

<!-- based upon work by Lisias -->

# OhScrap! (OS)

[Home](./index.md)

Scrapyard Based Part Failure addon plugin for Kerbal Space Program.

## Installation Instructions

### Using CurseForge/OverWolf app or CKAN

You should be all good! (check for latest version on CurseForge)

### If Downloaded from CurseForge/OverWolf manual download

To install, place the `OhScrap` folder inside your Kerbal Space Program's GameData folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**
  * Delete `<KSP_ROOT>/GameData/OhScrap`
* Extract the package's `OhScrap/` folder into your KSP's GameData folder as follows:
  * `<PACKAGE>/OhScrap` --> `<KSP_ROOT>/GameData`
    * Overwrite any preexisting folder/file(s).
  * you should end up with `<KSP_ROOT>/GameData/OhScrap`

### If Downloaded from SpaceDock / GitHub / other

To install, place the `GameData` folder inside your Kerbal Space Program folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**
  * Delete `<KSP_ROOT>/GameData/OhScrap`
* Extract the package's `GameData` folder into your KSP's root folder as follows:
  * `<PACKAGE>/GameData` --> `<KSP_ROOT>`
    * Overwrite any preexisting file.
  * you should end up with `<KSP_ROOT>/GameData/OhScrap`

## The following file layout must be present after installation

```markdown
<KSP_ROOT>
  + [GameData]
    + [ScrapYard]
      ...
    + [OhScrap]
      + [Agencies]
        ...
      + [Compatibility]
        ...
      + [Config]
        ...
      + [Contracts]
        ...
      + [Flags]
        ...
      + [Localization]
        ...
      + [Plugins]
        ...
      * #.#.#.#.htm
      * Attributions.htm
      * changelog.md
      * GPL-2.0.txt
      * ManualInstallation.htm
      * OhScrap.version
      * readme.htm
    ...
    * [Module Manager /L][mml] or [Module Manager][mm]
    * ModuleManager.ConfigCache
  * KSP.log
  ...
```

### Dependencies

* [ScrapYard (SY)][SY]
* *either*
  * [Module Manager /L][mml]
  * [Module Manager][mm]

[SY]: https://forum.kerbalspaceprogram.com/index.php?/topic/178641-* "ScrapYard (SY)"
[mm]: https://forum.kerbalspaceprogram.com/index.php?/topic/50533-*/ "Module Manager"
[mml]: https://github.com/net-lisias-ksp/ModuleManager "Module Manager /L"
