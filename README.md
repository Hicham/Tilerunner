# Level generator
De levels worden opgeslagen in JSON, in een array. Elke string is een layer in het level, en elk nummer of letter daarin verwijst naar een object.
Als voorbeeld de letter G staat voor brick en A voor air. Als de 1e string van de array "GG" bevat. spawnen er 2 blokjes naast elkaar.

Objecten en de letters kunnen aangepast worden naar keus zonder problemen.

# Objecten
De objecten die nu in de game staan zijn komen van een gratis asset.
Sommige objecten hebben animaties, maar niet alle objecten zijn getest.

# Objecten toevoegen of wijzigen
In "JsonToLevel.cs" kunnen er nieuwe variabelen gemaakt worden. Maak ze wel public zodat je in de editor zelf de objecten kan slepen in de variabelen. En maak je een if statement zoals hieronder aangegeven wordt.
```
if (letter.ToString() == *de letter je het object wilt geven)
{
  gameObj = *object naam
}
```
# To do List
We hebben niet goed gefocused op het spel zelf, en heeft het spel dus weinig inhoud.

De game heeft nu één enemy met de naam goombo. Als de speler tegen de zijkant komt gaat hij dood, en als je op zn hoofd springt stuitert de speler en gaat de gomboo dood.
Alleen is de automatische movement van de goombo nog heel beperkt. Hierdoor moet iets op bedacht worden.

Als er een level word gemaakt die diep omlaag gaat. Moet er nu opgepast worden voor opengaten.
Nu zoekt de script naar het laagste object in de game en als de speler er onder komt gaat hij dood.
Als er een gat in het level komt als opstakel en daar ver onder zit een level gaat de speler niet dood.
