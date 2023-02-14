# CS361 Project - PF2 Encounter Builder

Encounter builder for the Pathfinder 2nd edition TTRPG.




## Random_Number_Server API

Takes a range given as a string of the form "min,max" where min is the minimum valuer in the range and max is the maximum value in the range and returns a random number within that range. The number is returned as a string.
Implementation is done using the ZeroMQ library.

### Example python code:

import zmq

context = zmq.Context()

socket = context.socket(zmq.REQ)

socket.connect("tcp://localhost:5555")

message = "1,10"

socket.send_string(message)

random_number = socket.recv()

### UML Sequence
![image](https://user-images.githubusercontent.com/35823125/218605290-bbbcffc9-7d35-4aa9-a41b-82dbf925ab6c.png)
