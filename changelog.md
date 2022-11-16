# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.0.0-preview.3](https://github.com/unity-game-framework/ugf-events/releases/tag/1.0.0-preview.3) - 2022-11-16  

### Release Notes

- No release notes.

## [1.0.0-preview.2](https://github.com/unity-game-framework/ugf-events/releases/tag/1.0.0-preview.2) - 2021-10-06  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-events/milestone/3?closed=1)  
    

### Changed

- Change event handler naming ([#8](https://github.com/unity-game-framework/ugf-events/pull/8))  
    - Change `EventHandler` and `EventHandler<T>` delegate names to `EventFunctionHandler` and `EventFunctionHandler<T>`.

## [1.0.0-preview.1](https://github.com/unity-game-framework/ugf-events/releases/tag/1.0.0-preview.1) - 2021-10-06  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-events/milestone/2?closed=1)  
    

### Added

- Add invoke extension for event interfaces ([#6](https://github.com/unity-game-framework/ugf-events/pull/6))  
    - Add `IEvent.Invoke()` and `IEvent<T>.Invoke()` methods.
    - Add `IEventDynamic.Invoke()` method.

## [1.0.0-preview](https://github.com/unity-game-framework/ugf-events/releases/tag/1.0.0-preview) - 2021-10-06  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-events/milestone/1?closed=1)  
    

### Changed

- Rework events ([#4](https://github.com/unity-game-framework/ugf-events/pull/4))  
    - Add `EventDynamic` class to call events dynamically without knowing event type.
    - Change `IEvent` and `IEvent<T>` interfaces to be separated and used with or without arguments.
    - Change `EventCollection` and related classes to support changed event interfaces.
    - Change `EventList` and `EventSet` classes to support changed event interfaces.

## [0.1.0-preview](https://github.com/unity-game-framework/ugf-events/releases/tag/0.1.0-preview) - 2021-03-25  

### Release Notes

- No release notes.


