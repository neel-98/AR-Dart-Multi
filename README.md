# AR-Dart-Multi 
This Project is made in Unity3D by using [ARCore](https://developers.google.com/ar/develop) which is Google's Platform for building Augmented Reality experiences. This project is basically a mini game which can be played by 2 players connected in same Wi-Fi. Player who host the game is given blue color darts while other is given red color darts. Darts can be thrown at a same time as well as on turn basis from each device, which depends on players how they want to play. Both Players are given 5 darts to play, which is in sync on both devices so they can see each other's scores along with remaining darts. 

[Clound Anchors](https://developers.google.com/ar/develop/unity-arf/cloud-anchors/overview) are used to accomplish  multiplayer functionality. Cloud Anchors are anchors that are hosted on [ARCore Cloud Anchor] Service(https://console.cloud.google.com/apis/library/arcorecloudanchor.googleapis.com). 
ARCore connects to the ARCore Cloud Anchor service to host and resolve Cloud Anchors and enable shared experience. 

Here’s a high-level picture of how hosting and resolving works:

1. The user creates a local anchor in their environment.
2. The anchor is hosted — ARCore uploads that local anchor’s data to the ARCore Cloud Anchor service, and the ARCore Cloud Anchor service returns a unique ID for that anchor.
3. The app distributes that unique ID to other users.
4. The anchor is resolved — Users whose devices have the unique ID can recreate the same anchor using the ARCore Cloud Anchor service.

### Hosting
By using 3D feature map ARCore maps the environment by viewing center of interest from different angles. The ARCore Cloud Anchor Service then creates a 3D feature map of the Space and returns a unique Cloud Anchor ID.

https://user-images.githubusercontent.com/37670032/149366902-13f9f2c5-a34a-464c-bce0-0b8833a969b7.mp4

### Resolving
When another user in the same environment points their device’s camera at the area where the Cloud Anchor was hosted, a resolve request causes the ARCore Cloud Anchor service to periodically compare visual features from the scene against the 3D feature map that was created. ARCore uses these comparisons to pinpoint the user's position and orientation relative to the Cloud Anchor.

https://user-images.githubusercontent.com/37670032/149367080-43f9bc9f-a30a-4402-a3af-e2a6b5d92a3a.mp4

For this AR Dart Game, Dart Board is used as an Anchor and hosted by the user who created a Room for the Game.

### Rooms
The main screen when the game is launched can show the options to join currently hosted Rooms or to create a new Room.

<p align="center">
  <img src="https://github.com/neel-98/AR-Dart-Multi/blob/main/screenshots/Screenshot_20190712-222331_AR%20Dart%20Multi.jpeg" width="400"/>
</p>

### Hosting Anchor as a Dart Board
In the screenshot attach below, It can be seen white grid like structure, which ARCore is detecting as a plain. And when Player touches any part of the detected plain, It will place a dart board at that place as an Anchor. All the other objects like darts, will be placed in reference to this anchor and can be tracked considering Dart board as an reference point.

<p align="center">
  <img src="https://github.com/neel-98/AR-Dart-Multi/blob/main/screenshots/Screenshot_20190712-222424.jpeg" width="400"/>
</p>

<br/><br/>

<p align="center">
  <img src="https://github.com/neel-98/AR-Dart-Multi/blob/main/screenshots/Screenshot_20190712-222611.jpeg" width="400"/>
</p>
