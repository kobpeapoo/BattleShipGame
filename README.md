# BattleShipGame
For Test MAAS Company

# Install Project
1. Use SQL Server
2. Create Database "BattleShip"
3. Execute InitialDatabase.sql
4. Edit Connection String in appsettings.Development.json  to your machine 
"ConnectionStrings": {
    "BattleShip": "Server=THNB-16470\\SQLEXPRESS;Database=BattleShip;Trusted_Connection=True;"
  }
5. Open BattleShipBoard.sln


### Start Game By
1. Run Program calll new game first GET Method ([Your HOST]/api/newGame) will return game id. you can look up in the Newgame table
2. Call Create Ship on board ([Your HOST]/api/Defender/[game Id]) was not finish yet.you can look up in the Defender table
3. Call Attacker by passing the Game id also ([Your Host]/api/Attacker/[Game Id]) you can look up in the Attacker table
4. if you call Attacker you will get response (Miss , Hit , Mark X and Summary status)  =>{"Status":"Win","Miss":14,"shoot":18}
 
