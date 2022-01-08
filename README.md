# StreamlinkTwitchLoader

A simple C# desktop application that will load an arbitrary number of Twitch streams into VLC using Streamlink.  Currently, the streams are muted when loaded.

## Prerequisites

You must install both Streamlink and VLC.  You can do this one of three ways.

### Manual install

Visit the websites for both [Streamlink](https://streamlink.github.io/) and [VLC](https://www.videolan.org/).  You can install the applications manually.

### Chocolatey

You can install both applications via [Chocolatey](https://chocolatey.org/):

```
choco install streamlink vlc
```

### winget

You can install both applications via [winget](https://winget.run/):

```
winget install -e --id Streamlink.Streamlink
winget install -e --id VideoLAN.VLC
```

## Installing

There currently is not an installer, so just compile the code and run the resulting executable.

## Roadmap

Currently, there is no roadmap to a v1.0.0 release.  This project was largely created for myself So I can easily load Twitch streams into VLC.  This is the software I use to run [Monthly Tetris](https://ctm.gg/)'s Tetris Deathmatch.

With that said, I may add the following in the future:

* Specify the window size
* Specify whether to mute the windows or not
* Add a stl:// URL protocol handler to allow the application to automatically load a player via a link.

If you have any feature requests, please let me know.

## Version History

### v0.1.0

* Initial version.
