# BeatSaverSharper

A C# library to interact with the [BeatSaver](https://beatsaver.com) [API](https://api.beatsaver.com/docs).

## ⬇️ Downloading

If you're trying to download this as a dependency for a Beat Saber mod, go to the [Releases](https://github.com/Auros/BeatSaverSharper/releases/latest) page, find and download the latest (or the one that you need) `BeatSaverSharper-Beat Saber.zip`, download it, and extract it in your `Beat Saber` folder.

Alternatively, you can pick up the latest successful build based off of `main` in the [GitHub Actions](https://github.com/Auros/BeatSaverSharper/actions) page as an artifact (both normal and Unity versions).

## 🌱 Origin

This project is a replacement/continuation of BeatSaverSharp, the official .NET library for interacting with the BeatSaver API made by [lolPants](https://github.com/lolPants). It has since been taken down since it was no longer compatible with the new [BeatSaver](https://github.com/beatmaps-io/beatsaver-main) made by [Top_Cat](https://github.com/Top-Cat).

## 🛠️ Building

Building requires at least the .NET 7 SDK. The main project is .NET Standard 2.0, however the tests use .NET 7.

Pull from git or download this repository.

If on CLI, you can run

```
dotnet restore
```
to restore all of the project dependencies.

Then you will be able to build using 
```
dotnet build
```

## 🧪 Testing

The tests **DO NOT** work with the `Release-Unity` configuration, so make sure you're not building for that release.

In order for the tests to be functional, [BeatSaver](https://beatsaver.com)'s API needs to be online.

If on CLI, you can run the tests using
```
dotnet test
```

## ✈️ Contributing

If you want to contribute, fork this repository and make a new branch on your repository! I don't recommend working directly on your `main` branch because it'll be harder to rebase and fetch if you want to contribute in the future.

Once you've made your changes, create a [Pull Request](https://github.com/Auros/BeatSaverSharper/pulls) and reasonably list the changes you've made in bullet points

Example:
Title - Added exampleProperty to User model
```
Beat Saver got an update, so I've decided to add the new property.

* Added a new property `exampleProperty` to the `User` model since it was recently added to BeatSaver's API
```

Hopefully the tests pass, and I look at it. Feel free to message me (Auros#0001) on Discord right afterwards about it too, and continually remind me if I don't look at it.

## 🤡 BeatSaverSharper?
I hardly know her!


## A note on how this fork was made

I'm not a professional programmer. I do some Android development, but Unity/Harmony
modding is new to me, so I know just enough to spot when something has gone wrong and
roughly how to fix it.

This fork's changes were made with AI assistance. I direct the work, review what it
produces, and test everything on real hardware before it goes into a release. I'm
sharing this because I'd rather be upfront about it than have you wonder. This
disclaimer covers this fork's own changes only — the original mod is the work of its
original author(s).

I understand not everyone is comfortable with AI-assisted code, and that's a fair
position; a lot of people here have spent years building real expertise. If you'd
rather check things yourself, everything is open and the commits are small. Bug
reports, reviews and corrections are very welcome, and I'll fix what I get wrong.
