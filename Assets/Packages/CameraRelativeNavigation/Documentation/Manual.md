# Camera Relative Navigation

## Navigation

The `Navigation` script moves a character using input relative to the current camera direction.

### Member Variables

```csharp
public Camera camera;
public float speed;
public float smooth;
```

|         |                                                  |
|---------|--------------------------------------------------|
| camera  | the camera to use for relative movement          |
| speed   | speed of movement in metres per second           |
| smooth  | time of smoothing over movement                  |

### Public Member Functions

```csharp
public void RelativeMovement(Vector3 movement);
```

The movement vector to apply in camera local co-ordinates. X is left / right, Z is forward / back. The function transforms this direction into a global movement direction based on the camera transform.

#### Parameters

|          |                                                  |
|----------|--------------------------------------------------|
| movement | movement in camera local co-ordinates            |

## Example Scene

This scene has a player object with the maivagtion script attached. The camera has a `TestInput` script attached which sends the Unity standard input axes to the `Navigation` script. The camera tries to track the player.