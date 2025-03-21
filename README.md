Input :
 -
- Movement : ZQSD
- Saut : Espace
- Glissage : Ctrl
- Tir : clique gauche

Demande pour le multijoueur :
 -
        Système de create (nombre maximum de joueurs, nombre de points à atteindre et Seed), find et join session. 
        La première map est en solo puis les joueurs se rejoignent sur une map de d'entranement depuis laquel on peut :
        - Changer de pseudo
        - Tester les méchaniques 
        - Lancer la partie dans le dongeon généré procéduralement.
        
        1) Spawn d'objets (en plus des joueurs) :
        - Bonus pistolet permetant du roquet jump
        - Sphere pour gagner des points
        - Projectile tirrable quand on possède le bonus pistolet (clique gauche)
        
        2) Des objets qui se déplacent ou rotate :
        - Tourniquet tournant en continue (dans les salles générés procéduralement et dans le lobby)
        
        3) Un système d'interaction entre le joueur et son environnement qui s'affiche sur l'UI des autres joueurs :
        - Augmentation de score qui s'affiche chez tout le monde
        
        4) Un élément qui se sauvegarde entre deux lancement du jeu (En plus du nom des joueurs) :
        - Points depuis la dernière session
        - Dernière Seed généré (déterminé à la création de la LAN)
        - Nombre de point à atteindre (déterminé à la création de la LAN)
        
        5) Une action de personnage via un input :
        - Wall run (en avançant collé à un mur)
        - Wall jump (sauté en attant à l'état de Wall run)
        - Slide (Ctrl)
        - Roquet jump -> Projectile tirrable quand on possède le bonus pistolet (clique gauche)

        Bonus :
        - Dongeon généré procéduralement en fonction d'une seed random ou déterminée à la création de la LAN

Chemin important :
 -
 - Les managers : /All/Game/Manage
 - Les maps : /All/Game/Maps
 - Le joeur : /All/Game/FirstPerson/Blueprints/Player
 - Le PickUp pistolet et projectile : /All/Game/FirstPerson/Blueprints/Weapon
 - UI : /All/Game/UI
 - Blueprint pour gagner des points, générateur du dongeon et le tourniquet : /All/Game/Procedural_Dungeon
 - Salle du dongeon : /All/Game/Procedural_Dungeon/Room/Speedroom

Visuel :
 -
Menu de creation de LAN :
![image](https://github.com/user-attachments/assets/98c6b6a4-551e-4db0-8fc3-9ea1ba79ca5b)

Menu de recherche de session : 
![image](https://github.com/user-attachments/assets/a2738e4e-70cf-40a9-8e36-bc3720d5a16f)

Lobby : ("Blue" est le serveur et "Hey" le client)
![image](https://github.com/user-attachments/assets/2261449c-7ab3-4a78-95d7-4da1c02fc220)

Interface lié aux autres joeurs :
![image](https://github.com/user-attachments/assets/07d648b8-8b23-4b62-8fc9-6e0f5e0ebb45)

Salle de Bonus :
![image](https://github.com/user-attachments/assets/ee494ad3-3a38-4129-b452-0074887ac52b)

Salle de point : (si le point n'y est pas c'est qu'il est actuellement dans l'une des 3 autres salles de point)
![image](https://github.com/user-attachments/assets/1929c16c-62da-436f-a765-40df0db92091) ![image](https://github.com/user-attachments/assets/f133e941-77e4-48dc-8062-76b21bf7fbe4)

Tourniquet :

![2025-03-21 16-47-22](https://github.com/user-attachments/assets/874f2ffb-d10a-4291-a459-6143a7c8b42c)


Wall Run/ Wall jump (par le client) :

![2025-03-21 16-54-33](https://github.com/user-attachments/assets/2892655f-4baf-4544-9669-b0e6590b8d4d)

