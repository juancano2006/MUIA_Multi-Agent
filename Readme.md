# MUIA Multi-Agents

### Inspiration

- This project is based in "A novel Communication Technique for Nanobots based on acoustic signals" article.
- This article proposes the use of nanobots to eliminate malicious cancer cells.
- The nanobots will be agents with swarm intelligence, based on the behavior of bees.


## Requirements

Unity version: 2019.1.5f1.

## Functions

Nanobots: Red spheres.
Malicious cells: Black boxes.

Each nanobots have the following capacities:

- Recognition of a cancer cell.
- Destruction of a cancer cell.
- Emission of vibrations to signal the position of the cancer.
- Detection of acoustic waves.

The pseudo-code of the NanoBeeAlgorithm, acording to the article, is:

```
Repeat
foreach “active” nanobot i:
pick up any sound signal in its surrounding;
If there are not any signal/cancer cells
search randomly;
If discovered a cancer cell
Then eliminate the cell and starts to dancing;
If a signal has been received
Then moves towards the higher intensity of the signal;
Until there is an “active” nanobot
```

## 3D version

Without a NavMesh and without a pathfinding algorithm, there be a new agent: the queen.

The Queen knows where is the tumoral cells and guide the rest of the agents to there.

The agents dont have quimicals, agents now have 10 lifes and, when it destroy one cell, 1 life is substrate from it.

## Extra credits
Camera Controller: https://github.com/UniFormal/TGView3D/blob/master/TGView3D/Assets/Scripts/FlyCamera.cs

Smoke: https://assetstore.unity.com/packages/vfx/particles/white-smoke-particle-system-20404

## Changelog

V2.0: Release 3D version

V1.0: Released version.

## Future Work

Work in a pathfinding algorithm to explore the terrain without a queen.

Fix some bugs in 3D version.
