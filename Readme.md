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

## Extra credits
Camera Controller: https://github.com/UniFormal/TGView3D/blob/master/TGView3D/Assets/Scripts/FlyCamera.cs

Smoke: https://assetstore.unity.com/packages/vfx/particles/white-smoke-particle-system-20404

## Changelog

V1.0: Released version.

##Future Work

Release the 3D version, that search malicious cells in the x, y, z axis.
