# [Optick: C++ Profiler For Games](https://optick.dev)
![GitHub](https://img.shields.io/github/license/bombomby/optick.svg) ![GitHub release](https://img.shields.io/github/release/bombomby/optick.svg) <br/>
Optick is a super-lightweight C++ profiler for Games.<br/>
It provides access for all the necessary tools required for efficient performance analysis and optimization:<br/>
instrumentation, switch-contexts, sampling, GPU counters.<br/>

## Build Status
| Windows | Linux | MacOS | Code Quality |
| ------- | ----- | ----- | ------------ |
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/601e878cd10b4794b207bd5faa8ef423)](https://app.codacy.com/app/bombomby/optick?utm_source=github.com&utm_medium=referral&utm_content=bombomby/optick&utm_campaign=Badge_Grade_Settings)
| [![Windows Build status](https://ci.appveyor.com/api/projects/status/bu5smbuh1d2lcsf6?svg=true)](https://ci.appveyor.com/project/bombomby/brofiler) | [![Linux+MacOS Build Status](https://travis-ci.org/bombomby/optick.svg)](https://travis-ci.org/bombomby/optick) | [![Linux+MacOS Build Status](https://travis-ci.org/bombomby/optick.svg)](https://travis-ci.org/bombomby/optick) | [![Total alerts](https://img.shields.io/lgtm/alerts/g/bombomby/optick.svg?logo=lgtm&logoWidth=18)](https://lgtm.com/projects/g/bombomby/optick/alerts/) [![Language grade: C/C++](https://img.shields.io/lgtm/grade/cpp/g/bombomby/optick.svg?logo=lgtm&logoWidth=18)](https://lgtm.com/projects/g/bombomby/optick/context:cpp) |

![](https://optick.dev/images/screenshots/optick/Optick.png)

| Features | Windows | Linux | MacOS | XBox | PS4 |
| -------- | ------- | ----- | ----- | ---- | --- |
| Instrumentation | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :grey_question: |
| Switch Contexts | :heavy_check_mark: ETW | :heavy_check_mark: FTrace | :heavy_check_mark: DTrace | :heavy_check_mark: | :grey_question: |
| Sampling | :heavy_check_mark: ETW | :hourglass_flowing_sand: | :hourglass_flowing_sand: | :grey_question: | :grey_question: |
| GPU | :heavy_check_mark: D3D12, Vulkan | :heavy_check_mark: Vulkan | :heavy_check_mark: Vulkan | | |

:heavy_check_mark: - works out of the box, :hourglass_flowing_sand: - in progress, :grey_question: - will be available soon for the certified developers

## Basic Integration (one line of code)
1) Copy 'src' folder from the repository or latest release to your game project
2) Add `OPTICK_FRAME("MainThread");` macro to the main loop of your game and `#include "optick.h"` header
```c++
#include "optick.h"
...
while( true ) 
{
	OPTICK_FRAME("MainThread");
	engine.Update();
}
```
3) Use `OPTICK_EVENT();` macro to instrument a function
```c++
void SlowFunction()
{ 
	OPTICK_EVENT();
	...
}
```
4) Edit `optick.config.h` to enable/disable some of the features in specific configs or platforms.<br/>(e.g. disabling Optick in final builds)

## API
All the available API calls are documented here:<br/>
https://github.com/bombomby/optick/wiki/Optick-API

## Samples
Run [generate_projects.gpu.bat](https://github.com/bombomby/optick/blob/master/generate_projects.gpu.bat) from the root folder to generate project files.<br/>
Open solution `build\vs2017\Optick.sln` with samples.

| [WindowsD3D12](https://github.com/bombomby/optick/tree/master/samples/WindowsD3D12) | [WindowsVulkan](https://github.com/bombomby/optick/tree/master/samples/WindowsVulkan) | [ConsoleApp](https://github.com/bombomby/optick/tree/master/samples/ConsoleApp) |
| ---------- | ------------ | ------------- |
| ![WindowsD3D12](https://optick.dev/images/screenshots/optick/WindowsD3D12.png) | ![WindowsVulkan](https://optick.dev/images/screenshots/optick/WindowsVulkan.png) | ![ConsoleApp](https://optick.dev/images/screenshots/optick/ConsoleApp2.png) |
| DirectX12 multithreading sample with Optick integration | SaschaWillems's vulkan multithreading sample with Optick integration | Basic ConsoleApp with Optick integration  (Windows, Linux, MacOS) |

## Brofiler
Brofiler has been renamed into Optick since version 1.2.0.<br/>
All the future development is going under the new name.<br/>
Upgrade to the new version should be quite easy:
* `BROFILER_FRAME("MainThread");` => `OPTICK_FRAME("MainThread");`
* `BROFILER_THREAD("WorkerThread");` => `OPTICK_THREAD("WorkerThread");`
* `BROFILER_CATEGORY("Physics", Brofiler::Color::Green);` => `OPTICK_CATEGORY("Physics", Optick::Category::Physics);`
* `BROFILER_EVENT(NAME);` => `OPTICK_EVENT(NAME);`
* `PROFILE;` => `OPTICK_EVENT();`

## How To Start?
You can find a short instruction here:<br/>
https://github.com/bombomby/optick/wiki/How-to-start%3F-(Programmers-Setup)

