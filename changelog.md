# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [2.0.0-preview](https://github.com/unity-game-framework/ugf-events/releases/tag/2.0.0-preview) - 2023-01-08  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-events/milestone/7?closed=1)  
    

### Added

- Add event arguments interface ([#15](https://github.com/unity-game-framework/ugf-events/issues/15))  
    - Add `IEventArguments` interface.
    - Change `EventArguments` class to implement `IEventArguments` interface.

### Removed

- Remove EventDispatcherRedirection with single generic argument ([#16](https://github.com/unity-game-framework/ugf-events/issues/16))  
    - Remove `EventDispatcherRedirection<T>` and related classes, use `EventDispatcherRedirection<T, T>` class instead.

## [1.1.0](https://github.com/unity-game-framework/ugf-events/releases/tag/1.1.0) - 2023-01-04  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-events/milestone/5?closed=1)  
    null

### Added

- Add dispatcher redirection with different arguments ([#13](https://github.com/unity-game-framework/ugf-events/issues/13))  
    - Add `EventDispatcherRedirection<T, T>` generic class as redirection implementation with ability to convert arguments.

## [1.0.0](https://github.com/unity-game-framework/ugf-events/releases/tag/1.0.0) - 2023-01-03  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-events/milestone/4?closed=1)  
    

### Added

- Add event dispatcher ([#11](https://github.com/unity-game-framework/ugf-events/issues/11))  
    - Update dependencies: add `com.ugf.initialize` of `2.9.0` version.
    - Update package _Unity_ version to `2022.2`.
    - Add `EventDispatcher<T>` and related classes to manage events invocation and redirection.

## [1.0.0-preview.3](https://github.com/unity-game-framework/ugf-events/releases/tag/1.0.0-preview.3) - 2022-11-16  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-events/milestone/6?closed=1)  
    
### Remove

- Remove invoke from the interface (#9)
  - Update package _Unity_ version to `2022.1`.
  - Update package _API Compatibility_ version to `.NET Standard 2.1`.
  - Change `EventList`, `EventSet` and related classes of `Invoke()` method work.
  - Remove `IEvent.Invoke()`, `IEvent<T>.Invoke()` and `IEventDynamic.Invoke()` methods.

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


