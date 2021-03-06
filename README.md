# Connect 4
## Description
Connect 4 game provides a great experience for players where each 2 players can enter a room and start their own challenge.
Not only that, but players can enter the room as spectators and watch the ongoing game.
Players are allowed to create their own rooms, accept or reject a player upon joining the room, choose their own board size for a leveled up challenge
and pick a color for their coin to start playing.
## Scenario
1. Player logs into the game, after entering a unique username.
2. Player navigates through a menu, where he can enter play mode.
3. Play mode allows player to view all online players, available free rooms and full rooms.
4. Player can create a room then a dialog box appears requesting him to enter a unique room name, choose a suitable board size, choose his favourite color.
5. After creating the room, player enters the room and waits for other player to join.
6. If another player joined the room, the room owner then starts the game by pressing the play buttton.
7. The winner gets a message to congratulate him, while the loser receives a message saying that he has lost.
8. If a player wants to watch the game, he can select a room from the list of full rooms then press watch button.
9. If player is done, he signs out from the game.

## Use Case Diagram
<p align="center">
  <img src="https://github.com/ahmedsamy1234/TheBox/blob/GuiLogic/UseCase.png">
</p>

## Use Case Scenario
[Use Case Scenario](https://docs.google.com/spreadsheets/d/1paeOypDQef4iQE7QlhAYTQWmZf36QmsAR7YySipvPeQ/edit?usp=sharing).

## Sequence Diagram 
<p align="center">
  <img src="https://github.com/ahmedsamy1234/TheBox/blob/GuiLogic/SeqDiagram.png">
</p>

## Class Diagram
<p align="center">
  <img src="https://github.com/ahmedsamy1234/TheBox/blob/GuiLogic/UML.png">
</p>

## Activity Diagram 1
<p align="center">
  <img src="https://github.com/ahmedsamy1234/TheBox/blob/GuiLogic/Activity Diagram 1.jpeg">
</p>

## Activity Diagram 2
<p align="center">
  <img src="https://github.com/ahmedsamy1234/TheBox/blob/GuiLogic/Activity diagram 2.png">
</p>

## Design Patterns
- Memento
- Singleton
- [Classes Design UML and Sequence Diagram](https://app.diagrams.net/#G1R-aCJOE3QRefbgPOe4FvvqD7ookj1vLj).
## Protocols

|Request|Response|Details|
| :-: | :-: | :-: |
|log|ResponseLog|<p></p><p>Player logs into the game, the server then receives that player</p><p></p>|
|showplayer|ResponseShowPlayer|<p></p><p>Once the player logs in, the server responds with the online players list</p><p></p>|
|showrooms|ResponseShowRooms|<p></p><p>Once the player logs in, the server responds with the online rooms list</p><p></p>|
|end|-|<p></p><p>Specifies the end of list of rooms or players in server</p><p></p>|
|create|ResponseCreate|<p></p><p>When a room is created, the player who created the room, id(room name), index(Size of board) are sent to the server to create the room, then server responds with the room created and player1 is assigned to that room</p><p></p>|
|join|ResponseJoin|<p></p><p>Player 2 requests to join a room, server responds with the joined room and is redirects the player</p><p></p>|
|play|ResponsePlay|<p></p><p>Player Sends the room ID to the server, then the server responds with the room where the game is created</p><p></p>|
|ConfigPlayer1|-|<p></p><p>Server waits for player 1 to play </p><p></p>|
|ConfigPlayer2|-|<p></p><p>Server waits for player 2 to play</p><p> </p>|
|<p></p><p>ReceiveState</p><p></p>|ResponseRecieveState|Receives the state of board |
|<p></p><p>Exit</p><p></p>|-|Player is disconnected from server|
## Features
### Client
- Request user creation.
- View online players.
- View full rooms.
- View free rooms.
- Request room creation.
- Specify board size.
- Specify coin color.
- Join room as player.
- Join room as watcher.
### Server
- Create user.
- Create room.
- Instantiate game.
- Handle player's turn.
- Check player state.
## How to Use
- Run the server.
- Run the client.
- Enter username.
- Press Play.
- Press Create Room.
- Enter required data.
- Run another client.
- Navigate to Play.
- Double click on the shown room.
- The first client press play button.
## Screenshots
![This is an image](https://user-images.githubusercontent.com/72733603/154560183-03f95fc2-1c25-4619-9f88-99533a44e91a.png)
![This is an image](https://user-images.githubusercontent.com/72733603/154560238-28a248f2-e598-45ac-93dd-56b0e656b8b6.png)
![This is an image](https://user-images.githubusercontent.com/72733603/154561254-2912764e-790a-4c79-8d09-c81b15cde0c8.png)
![This is an image](https://user-images.githubusercontent.com/72733603/154561303-b0772944-ea17-48fe-9b6a-c2ea9c499c1e.png)
![This is an image](https://user-images.githubusercontent.com/72733603/154560353-41b5be0b-4925-4a97-9678-db5e21d181db.png)
![This is an image](https://user-images.githubusercontent.com/72733603/154560375-59a33145-6c5a-4ffc-aa5a-0df0b8ab9358.png)
![This is an image](https://user-images.githubusercontent.com/72733603/154560384-b1a17b61-9836-49f8-9895-24924f5a68c4.png)
![This is an image](https://user-images.githubusercontent.com/72733603/154560384-b1a17b61-9836-49f8-9895-24924f5a68c4.png)
![This is an image](https://user-images.githubusercontent.com/72733603/154561367-1fc63011-cf55-4b21-9635-6952d223e018.png)
