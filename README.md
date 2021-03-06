![Box2D Logo](https://box2d.org/images/logo.svg)

# Build Status
[![Build Status](https://travis-ci.org/erincatto/box2d.svg?branch=master)](https://travis-ci.org/erincatto/box2d)

# b2Sharp

b2Sharp is Box2D physics engine native wrapper for C#.

## Contributing

Please do not submit pull requests with new features or core library changes. Instead, please file an issue first for discussion. For bugs, I prefer detailed bug reports over pull requests.

## Features 
( as with latest Box2D version 2.3.1 )

### Collision
- Continuous collision detection
- Contact callbacks: begin, end, pre-solve, post-solve
- Convex polygons and circles
- Multiple shapes per body
- One-shot contact manifolds
- Dynamic tree broadphase
- Efficient pair management
- Fast broadphase AABB queries
- Collision groups and categories

### Physics
- Continuous physics with time of impact solver
- Persistent body-joint-contact graph
- Island solution and sleep management
- Contact, friction, and restitution
- Stable stacking with a linear-time solver
- Revolute, prismatic, distance, pulley, gear, mouse joint, and other joint types
- Joint limits, motors, and friction
- Momentum decoupled position correction
- Fairly accurate reaction forces/impulses

### System
- Small block and stack allocators
- Centralized tuning parameters
- Highly portable C++ with no use of STL containers

### Testbed
- OpenGL with GLFW
- Graphical user interface with imgui
- Extensible test framework
- Support for loading world dumps

## Generate SWIG

        swig -csharp -c++ -includeall -ignoremissing -namespace b2Sharp -outdir swig ./src/box2d.i

## Building
- Install [CMake](https://cmake.org/)
- Ensure CMake is in the user `PATH`
- Visual Studio: run `build.bat` from the command prompt
- Otherwise: run `build.sh` from a bash shell
- Results are in the build sub-folder
- On Windows you can open box2d.sln
- Box2DCS: continue building the C# Project after wrapper/library is done.

## Usage 
- The result path of `Wrapper/Native Dylib` & `dotNET DLL` :

        /build/src/libbox2d.dylib
        /build/src/b2Sharp.dll

- Unity Usage : put into unity `/Assets` folder then in script :

        import b2Sharp;

## Documentation
- [Manual](https://box2d.org/documentation/)
- [reddit](https://www.reddit.com/r/box2d/)
- [Discord](https://discord.gg/NKYgCBP)

## License
Box2D is developed by Erin Catto, and uses the [MIT license](https://en.wikipedia.org/wiki/MIT_License).

## Sponsorship
Support development of Box2D through [Github Sponsors](https://github.com/sponsors/erincatto)
