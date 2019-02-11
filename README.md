# TileRunner

Project gemaakt door:
- Nick
- Wesley
- Hicham

# Level generator
De levels worden opgeslagen in JSON, in een array. Elke string is een layer in het level, en elk nummer of letter daarin verwijst naar een object.
Als voorbeeld de letter G staat voor een blokje en A voor air. Als de 1e string van de array "GG" bevat. spawnen er 2 blokjes naast elkaar.

Objecten moeten momenteel 1x1 zijn. Anders spawnen ze niet netjes naast of op elkaar. Objecten kunnen wel kleiner of groter zijn maar moet je die beter positioneren en staan ze niet altijd goed naast of op elkaar.

Objecten en de letters kunnen aangepast worden naar keus zonder problemen, zolang de if statements kloppen en de objecten goed geïmporteerd zijn.

# Objecten
De objecten die nu in de game staan zijn komen van een gratis asset.
Sommige objecten hebben animaties, maar niet alle objecten zijn getest.

Het kan gebeuren dat de prefabs niet werken na het downloaden, dan moet je nieuwe maken van de sprites die er zijn, zelf andere sprites importeren of ze zelf designen.

# Objecten toevoegen of wijzigen
In "JsonToLevel.cs" kunnen er nieuwe variabelen gemaakt worden. Maak ze wel public zodat je in de editor zelf de objecten kan slepen in de variabelen. En maak je een if statement zoals hieronder aangegeven wordt in de generator loop.
```
if (letter.ToString() == *de letter je het object wilt geven)
{
  gameObj = *object naam
}
```
# To do List
We hebben niet goed gefocused op de game zelf, en hierdoor heeft de game dus weinig inhoud.

De game heeft nu één enemy met de naam goombo. Als de speler tegen de zijkant komt gaat hij dood, en als je op zn hoofd springt stuitert de speler en gaat de goombo dood.
Alleen is de automatische movement van de goombo nog heel beperkt. Hierdoor moet iets op bedacht worden.

Als er een level word gemaakt die diep omlaag gaat. Moet er nu opgepast worden voor opengaten.
Nu zoekt de script naar het laagste object in de game en als de speler er onder komt gaat hij dood.
Als er momenteel een gat in het level komt als opstakel en daar ver onder nog een deel van het level zit gaat de speler niet dood.

De speler heeft nog ook geen levens, dit is een mooie extra feature.

Er moet ook nog gezocht worden naar een bijpassende achtergrond voor het spel.
