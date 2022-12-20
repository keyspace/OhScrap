<!-- readme.md v1.6.9.9
MOD-NAME (ABBV)
created: 17 Jul 2017
updated: 04 Oct 2022 -->

<!--this file: CC BY-ND 4.0 by zer0Kerbal-->

[![MOD-NAME][MOD:shd:latest]][MOD:forum] [![KSP version][KSP:shd]][KSP:url]  [![License][LIC:shd]][LIC:url]  
[![Curseforge][CURSFG:shd]][CURSFG:url] [![GitHub][GITHUB:shd]][GITHUB:url] [![SpaceDock][SPCDCK:shd]][SPCDCK:url] [![CKAN][ckan:shd]][ckan:url]  
[![Pages][MOD:pages:shd]][MOD:pages]

![Code][CODE:shd]

# Oh Scrap! (OS) (formerly UPFM)

Scrapyard Based Part Failure addon plugin for Kerbal Space Program.

## By [`zer0Kerbal`][zer0Kerbal], originally by [`severedsolo`][severedsolo]

adopted with *express* permission and brought to you by *KerbSimpleCo*

<img src="https://raw.githubusercontent.com/zer0Kerbal/OhScrap/master/img/HeroLogo_1920x1920.png" alt="OhScrap Hero" width="50%" height="50%">

### Preamble by [severedsolo][severedsolo]

> Poor Val, she's not having a good day. There she was on her way back from orbit, and this happened:
>
> ![A bad day for Val](https://i.imgur.com/2V0F5DT.png)
>
> You see, I forgot to take her shiny new ship for a test flight before sending it to space, so the reaction wheels failed. Then her oxygen started venting into space. So she quickly burned retrograde and started her re-entry. Except that as she came into land, the parachute failed too. Like I said, not a good day.
>
>Sound exciting? Then why don't you install Oh Scrap! today.

### Features

* Part Failures: Parachutes, Engines, Gimbals, Resources, Batteries, Reaction Wheels, Control Surfaces - all these failures can make your day turn out like Vals. (all can be disabled or enabled through the difficulty settings menu)
* Failures follow the [bathtub curve](https://en.wikipedia.org/wiki/Bathtub_curve) - brand new untested parts are more likely to fail than pre-tested models. If you re-use a part too many times though, it will reach the end of it's shelf-life and be more prone to failure.
* Subsequent "new models" of parts become more reliable than their earlier counterparts. Ie, a part you've just researched is more likely to fail than a part that has been tried and tested many times - even if it's brand new.
* Repairs - some parts can be repaired remotely, some need an EVA. You always have a better chance of repairing a part on EVA

### See more

>* [GitHub Pages][MOD:pages]
>* [Marketing Slicks][MOD:markt]
>* [Discussions][MOD:discu] or [KSP Forums][MOD:forum] for discussions and news
>* [ChangeLog][MOD:chlog] for more details of changes
>* [Known Issues][MOD:issue] for more details of feature requests and known issues

### YouTube video [`Lu`](https://www.youtube.com/@user-ur8lh6oj4s)

[![Testing the K-1 with Oh Scrap | Kerbal Space Program](https://img.youtube.com/vi/kn-Dm_6TQ7s/0.jpg)](https://youtu.be/kn-Dm_6TQ7s)

### Localization

>* ![English][EN] English
>* ![中文][CN] Simplified Chinese (中文) - courtesy of 
>* ***your translation here***
>
> HELP WANTED - See the [README in the Localization folder][lreadme] or the [Quickstart Guide][qstart] for instructions for adding or improving translations. [GitHub][GitHub:url] push is the best way to contribute. *Additions and corrections welcome!*

---

### Installation Directions [^1]

***Use***
  CurseForge/OverWolf App (currently does not install dependencies)  

  <a href="https://download.curseforge.com/">
    <img src="https://www.overwolf.com/brand-guidelines/img/logo2.svg" alt="CurseForge/OverWolf App" width="15%" height="15%">
</a>

Whilst I agree CKAN is a great mod for those that can't use zip tools. I take no part, nor am I interested in maintaining the CKAN mod metadata for my mods.
Please don't ask me about it but refer to the CKAN mod thread if you are having issues with CKAN or the metadata it maintains. Beware, CKAN *can* really mess up though it tries very, very, very hard not to.

When I make a serious save / mod breaking change, CKAN will happily update you without you ever seeing a changelog. This means you could happily load your save, not notice the major version number has changed, and seriously break something. I do not like this. So CKAN users must use Kerbal Changelog, because that way nobody can say they weren't warned :).

or [![CKAN][CKAN:img]][CKAN:url]

### Dependencies

* [Kerbal Space Program][KSP:url] [![Kerbal Space Program][KSP:shd]][KSP:url] [^2]
* [ScrapYard](https://forum.kerbalspaceprogram.com/index.php?/topic/178641-*)  to keep track of how many times a part has been built/recovered so that is a hard dependency. (obtained separately)
* Either [^3] is required if you want the mod to actually do anything
  * [Module Manager][mm]
  * [Module Manager /L][mml]


### Recommends

* [Kerbal Construction Time](https://forum.kerbalspaceprogram.com/index.php?/topic/182877-*) designed with this with in mind, so would recommend that mod (make sure you use the latest dev version)
* [StageRecovery](https://forum.kerbalspaceprogram.com/index.php?/topic/179306-*) If you plan to actually re-use your parts (and have them fail), you'll probably want StageRecovery too
* [KRASH](http://forum.kerbalspaceprogram.com/index.php?/topic/133082-*)

### Supports

* [USI MKS](http://forum.kerbalspaceprogram.com/index.php?/topic/154587-*)

### Suggests

* [On Demand Fuel Cells (ODFC)][ODFC]
* [GPO (Goo Pumps & Oils') Speed Pump (GPO)][GPO]

### Tags

plugin,config,information,editor,sound,career,crewed,uncrewed

<div style="border:0.5px solid Tomato; background-color: #BADA55; color: #FF0000; text-align:center">
  <p><b>red box below is a link to forum post on how to get support</b></p>
  <a href="https://forum.kerbalspaceprogram.com/index.php?/topic/83212-*">
    <p><img src="https://i.postimg.cc/vHP6zmrw/image.png" alt="How to get support"></p></a>
  <p style="color: #000000;">Be Kind: Lithobrake, not jakebrake! Keep your Module Manager up to date</p>
</div>

### Credits and Special Thanks

* [`severedsolo`][severedsolo] for creating this glorious addon!
* [`magico13`][magico13] both for ScrapYard, and helping [me] with all my questions issues while making this.
* The maintainers/authors of DangIt - most of this would never have happened without looking at your code to figure out how to make stuff work.

### Legal Mumbo Jumbo (License *provenance*)

#### Current (2) - [`zer0Kerbal`][zer0Kerbal]

> Forum: [Thread][MOD:forum] - Source: [GitHub][GITHUB:url]  
> License: [![License][LIC:shd]][LIC:url] ![License][LIC:log]
>
> ##### Disclaimer(s)
>
> ***All bundled mods are distributed under their own licenses***  
> ***All art assets (textures, models, animations, sounds) are distributed under their own licenses***

##### see [Notices.md][MOD:notic] for more *legal mumbo jumbo*

#### Original (1) - Author: [`zer0Kerbal`][zer0Kerbal]

> Forum: [Thread][MOD:1:thread] - Download: [CurseForge][MOD:1:dnload] - Source: [GitHub][MOD:1:source]  
> License: [![License][LIC:1:shd]][LIC:1:url] ![License][LIC:1:log]

#### Original (0) - Author: [`severedsolo`][severedsolo]

> Forum: [Thread][MOD:0:thread] - Download: [SpaceDock][MOD:0:dnload] - Source: [GitHub][MOD:0:source]  
> License: [![License][LIC:0:shd]][LIC:0:url] ![License][LIC:0:log]

---

### DONATIONS: How to support this and other great mods by [`zer0Kerbal`][zer0Kerbal]  

> ***Completely voluntary, absolutely amazing, and really does help me out a lot!***
> <a href="https://forum.kerbalspaceprogram.com/index.php?/profile/32393-*/"><img border="0" alt="cybutek" src="https://kerbal-forum-uploads.s3.us-west-2.amazonaws.com/monthly_2020_06/kappa-kerbal-anarchy.thumb.png.673a2f6f7b36cc60a35c24efef217246.png" height="25" >cybutek</a> creator of <a href="https://forum.kerbalspaceprogram.com/index.php?/topic/17833-130-*/" alt="Kerbal Engineer Redux (KER)"> Kerbal Engineer</a>

[![Support][PAYPAL:img]][PAYPAL:url] [![Github Sponsor][GSPONS:img]][GSPONS:url] [![Patreon][PATREON:img]][PATREON:url] [![Buy zer0Kerbal a snack][BMCC:img]][BMCC:url]

*and it is true.*
<!-- mod links -->
[MOD:attr]: https://zer0kerbal.github.io/OhScrap/Attributions "Attribution"
[MOD:chlog]: https://raw.githubusercontent.com/zer0Kerbal/OhScrap/master/changelog.md  "Changelog"
[MOD:contr]: https://github.com/zer0Kerbal/.github/blob/master/.github/CONTRIBUTING.md "Contributing"
[MOD:discu]: https://github.com/zer0Kerbal/OhScrap/discussions "Discussions"
[MOD:forum]: https://forum.kerbalspaceprogram.com/index.php?/topic/192742-*/ "OhScrap Forum Thread"
[MOD:issue]: https://github.com/zer0Kerbal/OhScrap/issues "Issues"
[MOD:licns]: https://github.com/zer0Kerbal/OhScrap/blob/master/LICENSE "Github License"
[MOD:markt]: https://zer0kerbal.github.io/OhScrap/Marketing "Marketing Slicks"
[MOD:notic]: https://zer0kerbal.github.io/OhScrap/Notices "Notices"
[MOD:parts]: https://zer0kerbal.github.io/OhScrap/PartsCatalog "Parts Catalog"
[MOD:pages]: https://zer0kerbal.github.io/OhScrap "GitHub Pages"

<!--- mod -->
[MOD:shd:latest]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/OhScrap/master/json/mod.json

[CODE:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/OhScrap/master/json/code.json

[MOD:pages:shd]: https://img.shields.io/badge/GitHub-Pages-white?style=plastic&labelColor=9cf&logoColor=181717&logo=github "GitHub IO"

<!--- mod provenance -->
[MOD:1:dnload]: https://www.curseforge.com/kerbal/ksp-mods/OhScrap "CurseForge"
[MOD:1:source]: https://github.com/zer0Kerbal/OhScrap "GitHub"
[MOD:1:thread]: https://forum.kerbalspaceprogram.com/index.php?/topic/192360-*/ "KSP Forum"

[MOD:0:dnload]: https://www.dropbox.com/s/85og3xdhark7com/OhScrap5.rar?dl=0 "Dropbox"
[MOD:0:source]: https://www.dropbox.com/s/85og3xdhark7com/OhScrap5.rar?dl=0 "Dropbox"
[MOD:0:thread]: https://forum.kerbalspaceprogram.com/index.php?/topic/160854-*/ "KSP Forum"

<!--- license provenance -->
[LIC:0:url]: https://creativecommons.org/licenses/by-nc-sa/4.0/ "Expat-MIT"
[LIC:0:log]: https://i.postimg.cc/bvjfsMP5/MIT-17x17.png "Expat-MIT"
[LIC:0:shd]: https://img.shields.io/badge/License-Expat/MIT-3DA639?labelColor=black&logoColor=3DA639&logo=OpenSourceInitiative&style=plastic "Expat-MIT

[LIC:url]: https://creativecommons.org/licenses/by-nc-sa/4.0/ "CC BY-NC-SA 4.0"
[LIC:log]: https://licensebuttons.net/i/l/by-nc-sa/transparent/33/66/99/76x22.png "CC BY-NC-SA 4.0"
[LIC:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/OhScrap/master/json/license.json "CC BY-NC-SA 4.0"

<!--- GPLv2
[LIC:url]: https://www.gnu.org/licenses/gpl-2.0-standalone.html "GPLv2"  
[LIC:log]: https://i.postimg.cc/9FrwMgK6/GPL-17x17.png "GPLv2"
[LIC:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/OhScrap/master/json/license.json "GPLv2"
-->

<!-- Expat/MIT
" -->


<!--- AVC -->
[AVC:shd]: https://img.shields.io/badge/KSP-AVC--supported-00C961.svg?labelColor=black&style=plastic
[AVCVLD:shd]: https://github.com/zer0Kerbal/OhScrap/workflows/Validate%20AVC%20.version%20files/badge.svg?labelColor=black&style=plastic "AVC-Valid - thank you to DasSkelett"

<!--- CKAN -->
[CKAN:img]: https://i.postimg.cc/x8XSVg4R/sj507JC.png "CKAN"
[CKAN:url]: http://forum.kerbalspaceprogram.com/index.php?/topic/197082-*/ "CKAN"
[CKAN:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/OhScrap/master/json/ckan.json "CKAN"

<!--- release links -->
[CURSFG:url]: https://www.curseforge.com/kerbal/ksp-mods/OhScrap "Curseforge"
[CURSFG:shd]: https://img.shields.io/badge/CurseForge-Link-CCFF00.svg?labelColor=6441A4&style=plastic&logo=curseforge "Curseforge"

[GITHUB:url]: https://github.com/zer0Kerbal/OhScrap/ "GitHub"
[GITHUB:shd]: https://img.shields.io/badge/Github-Link-CCFF00.svg?labelColor=181717&style=plastic&logo=github "GitHub"

[SPCDCK:url]: http://spacedock.info/mod/2379 "SpaceDock"
[SPCDCK:shd]:  https://img.shields.io/badge/SpaceDock-Link-CCFF00.svg?labelColor=181717&style=plastic&logo=data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz4KPCEtLSBHZW5lcmF0b3I6IEFkb2JlIElsbHVzdHJhdG9yIDE5LjAuMCwgU1ZHIEV4cG9ydCBQbHVnLUluIC4gU1ZHIFZlcnNpb246IDYuMDAgQnVpbGQgMCkgIC0tPgo8c3ZnIHZlcnNpb249IjEuMSIgaWQ9IkxheWVyXzEiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgeG1sbnM6eGxpbms9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkveGxpbmsiIHg9IjBweCIgeT0iMHB4IgoJIHZpZXdCb3g9IjAgMCA1MDAgNTAwIiBzdHlsZT0iZW5hYmxlLWJhY2tncm91bmQ6bmV3IDAgMCA1MDAgNTAwOyIgeG1sOnNwYWNlPSJwcmVzZXJ2ZSI+CjxzdHlsZSB0eXBlPSJ0ZXh0L2NzcyI+Cgkuc3Qwe2ZpbGw6IzFBMUExQTt9Cgkuc3Qxe2ZpbGw6IzA1Nzg5Mzt9Cgkuc3Qye2ZpbGw6IzA3QUNEMjt9Cjwvc3R5bGU+CjxwYXRoIGlkPSJYTUxJRF8xXyIgY2xhc3M9InN0MCIgZD0iTTQwMCwwLjZIMTAwYy01NSwwLTEwMCw0NS0xMDAsMTAwVjQwMGMwLDU1LDQ1LDEwMCwxMDAsMTAwaDMwMGM1NSwwLDEwMC00NSwxMDAtMTAwVjEwMC42CglDNTAwLDQ1LjYsNDU1LDAuNiw0MDAsMC42eiIvPgo8ZyBpZD0iWE1MSURfNl8iPgoJPGcgaWQ9IlhNTElEXzlfIj4KCQk8cGF0aCBpZD0iWE1MSURfMTdfIiBjbGFzcz0ic3QxIiBkPSJNMTgzLjMsMTY1LjljNi40LTMuNiwxNi45LTMuNiwyMy4zLDBMNDY3LjQsMzE0YzYuNCwzLjYsNi40LDkuNiwwLDEzLjJMMjA2LjYsNDc0LjQKCQkJYy02LjQsMy42LTE3LjcsNi42LTI1LDYuNmgtNDQuOGMtNy40LDAtOC4xLTMtMS43LTYuNmwyNjEtMTQ3LjJjNi40LTMuNiw2LjQtOS42LDAtMTMuMkwxNzEsMTg2Yy02LjQtMy42LTYuNC05LjYsMC0xMy4yCgkJCUwxODMuMywxNjUuOXoiLz4KCTwvZz4KCTxnIGlkPSJYTUxJRF84XyI+CgkJPHBhdGggaWQ9IlhNTElEXzE2XyIgY2xhc3M9InN0MiIgZD0iTTMxOC44LDE5Yy03LjQsMC0xOC42LDIuOC0yNSw2LjRMMzMsMTczLjRjLTYuNCwzLjYtNi40LDkuNSwwLDEzLjFsMjYwLjcsMTQ3LjEKCQkJYzYuNCwzLjYsMTYuOSwzLjYsMjMuMywwbDEyLjMtN2M2LjQtMy42LDYuNC05LjUsMC0xMy4ybC0yMjUuMS0xMjdjLTYuNC0zLjYtNi40LTkuNSwwLTEzLjJMMzY1LjYsMjUuNGM2LjQtMy42LDUuNi02LjQtMS43LTYuNAoJCQlIMzE4Ljh6Ii8+Cgk8L2c+CjwvZz4KPC9zdmc+Cg==  "SpaceDock"

<!-- Kerbal Space Program -->
[KSP:url]: https://kerbalspaceprogram.com/ "Kerbal Space Program"
[KSP:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/OhScrap/master/json/ksp.json&logo=data:image/webp;base64,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 "Kerbal Space Program"

<!-- links to add-ons/mods -->
[ODFC]: https://forum.kerbalspaceprogram.com/index.php?/topic/187625-*/ "On Demand Fuel Cells (ODFC)"
[fs]: https://github.com/snjo/Firespitter/ "Firespitter"
[mm]: https://forum.kerbalspaceprogram.com/index.php?/topic/50533-*/ "Module Manager"
[mml]: https://github.com/net-lisias-ksp/ModuleManager "Module Manager /L"
[twk]: https://forum.kerbalspaceprogram.com/index.php?/topic/179030-*/ "TweakScale"
[far]: https://forum.kerbalspaceprogram.com/index.php?/topic/179445-*/ "FAR"
[restock]: https://forum.kerbalspaceprogram.com/index.php?/topic/182679-*/ "Restock"
[GPO]: https://forum.kerbalspaceprogram.com/index.php?/topic/207732-*/ "GPO SpeedPump (GPO)"
[atp]: https://forum.kerbalspaceprogram.com/index.php?/topic/138433-*/ "JSI Advanced Transparent Pods"
[b9ps]: https://forum.kerbalspaceprogram.com/index.php?/topic/140541-*/ "B9 Part Switch"
[kas]: http://forum.kerbalspaceprogram.com/index.php?/topic/142594-*/ "Kerbal Attachment System"
[kis]: http://forum.kerbalspaceprogram.com/index.php?/topic/149848-*/ "Kerbal Inventory System"
[kjr]: https://forum.kerbalspaceprogram.com/index.php?/topic/184206-*/ "Kerbal Joint Reinforcement-Next"
[kurs]: https://github.com/linuxgurugamer/DockingCam "KURS style docking camera"
[mas]:  https://forum.kerbalspaceprogram.com/index.php?/topic/160856-*/ "MOARdV's Avionics System"
[rpm]: https://forum.kerbalspaceprogram.com/index.php?/topic/105821-*/ "Raster Prop Monitor"

<!-- financial support -->
[PAYPAL:img]: https://img.shields.io/badge/Buy%20me%20some%20-LFO-BADA55?style=for-the-badge&logo=paypal&labelColor=FFDD00/ "PayPal"
[PAYPAL:url]: https://www.paypal.com/donate?hosted_button_id=DC22YHMEJREKL/ "PayPal"
[PATREON:img]: https://img.shields.io/badge/Patreon%20-Patreonize-FF424D?style=for-the-badge&logo=patreon/ "Patreon"
[PATREON:url]: https://www.patreon.com/bePatron?u=23390503/ "Patreon"
[GSPONS:img]: https://img.shields.io/badge/Github%20-Sponsor-EA4AAA?style=for-the-badge&logo=githubsponsors/ "Github Sponsors"
[GSPONS:url]: https://github.com/sponsors/zer0Kerbal/ "Github Sponsors"
[BMCC:img]: https://img.shields.io/badge/Buy%20Me%20a%20-Snack!-FFDD00?style=for-the-badge&logo=buymeacoffee/ "Buy Me A Snack"
[BMCC:url]: https://buymeacoffee.com/zer0Kerbal/ "Buy Me A Snack"

<!-- Localization -->
[lreadme]: https://github.com/zer0Kerbal/zer0Kerbal/blob/master/Localization/readme.md "Localization Readme"
[qstart]: https://github.com/zer0Kerbal/zer0Kerbal/blob/master/Localization/quickstart.md "Quickstart"
[EN]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/EN.png "English"  
[BR]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/BR.png "Português Brasil"
[CN]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/CH.png "中文"  
[DE]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/DE.png "Deutsch"  
[ES]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/ES.png "Español"  
[FR]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/FR.png "Français"  
[IT]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/IT.png "Italiano"  
[JA]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/JA.png "日本語"  
[KO]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/KO.png "한국어"  
[MX]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/MX.png "Mexicano Español"  
[NL]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/NL.png "Dutch"  
[NO]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/NO.png "Norsk"
[PO]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/PO.png "Polski"  
[RU]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/RU.png "Русский"  
[SW]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/SW.png "Svenska"  
[TR]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/TR.png "Türk"  
[TW]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/TW.png "国语"

[curseforge]: https://www.curseforge.com/members/zer0kerbal/projects
[reddit]: https://www.reddit.com/user/zer0Kerbal
[twitch]: https://www.twitch.tv/zer0kerbal
[twitter]: https://twitter.com/zer0Kerbal
[youtube]: https://www.youtube.com/@zer0Kerbal

[DaMichel]: https://forum.kerbalspaceprogram.com/index.php?/profile/102159-*/ "DaMichel"
[blackheart]: https://forum.kerbalspaceprogram.com/index.php?/profile/42741-*/ "Blackheart612"
[daemoria]: https://forum.kerbalspaceprogram.com/index.php?/profile/103696-*/ "Daemoria"  
[zer0Kerbal]: https://forum.kerbalspaceprogram.com/index.php?/profile/190933-*/ "zer0Kerbal"

[IMG:flg:0]: https://via.placeholder.com/256x160png/ffffff/bada55?text=KGEx "Mini Sample Return Capsule Flag"

---

#### Connect with me

Track progress: issues [here][MOD:issue] and projects [here](https://github.com/zer0Kerbal/OhScrap/projects/) along with **[The Short List](https://github.com/users/zer0Kerbal/projects/27)**

[<img align="left" alt="zer0Kerbal | kerbalspaceprogram.com" width="32px" src="https://cdn.icon-icons.com/icons2/1381/PNG/32/kerbalspaceprogram_93898.png" />][zer0Kerbal] [<img align="left" alt="zer0Kerbal | CurseForge" width="32px" src="https://cdn.jsdelivr.net/npm/simple-icons@v3/icons/curseforge.svg" />][curseforge] [<img align="left" alt="zer0Kerbal | reddit" width="32px" src="https://cdn.icon-icons.com/icons2/1945/PNG/512/iconfinder-reddit-4661631_122483.png" />][reddit] [<img align="left" alt="zer0Kerbal | Patreon" width="32px" src="https://cdn.icon-icons.com/icons2/2429/PNG/512/patreon_logo_icon_147253.png" />][PATREON:url] [<img align="left" alt="zer0Kerbal | YouTube" width="32px" src="https://cdn.icon-icons.com/icons2/836/PNG/512/Youtube_icon-icons.com_66802.png" />][youtube] [<img align="left" alt="zer0Kerbal | Twitch" width="32px" src="https://cdn.icon-icons.com/icons2/2699/PNG/512/twitch_logo_icon_170383.png" />][twitch] [<img align="left" alt="zer0Kerbal | PayPal" width="32px" src="https://cdn.icon-icons.com/icons2/2699/PNG/512/paypal_logo_icon_168055.png" />][PAYPAL:url] [<img align="left" alt="zer0Kerbal | Buy Me a Coffee" width="32px" src="https://www.buymeacoffee.com/assets/img/bmc-meta-new/new/favicon.ico" />][BMCC:url] [<img align="left" alt="zer0Kerbal | Twitter" width="32px" src="https://cdn.icon-icons.com/icons2/836/PNG/32/Twitter_icon-icons.com_66803.png" />][twitter]

<!-- footnotes -->
[^1]: this isn't a mod. ;P
[^2]: ***may*** work on other versions (YMMV)
[^3]: *Be Kind: Lithobrake, not jakebrake! Keep your Module Manager up to date!*


[MOD:forum]: https://forum.kerbalspaceprogram.com/index.php?/topic/160854-*/
[MOD:forum]: https://forum.kerbalspaceprogram.com/index.php?/topic/178641-*/
[MOD:spacedock]: https://spacedock.info/mod/2364

[magico13]: https://forum.kerbalspaceprogram.com/index.php?/profile/73338-*/ "magico13"
[severedsolo]: https://forum.kerbalspaceprogram.com/index.php?/profile/80345-*/ "severedsolo"
[zer0Kerbal]: https://forum.kerbalspaceprogram.com/index.php?/profile/190933-*/ "zer0Kerbal"
[linuxgurugamer]: https://forum.kerbalspaceprogram.com/index.php?/profile/129964-*/ "linuxgurugamer"