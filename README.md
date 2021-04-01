# CSharp.24.Indexers

Indexer nos permite trabajar con un objeto como si fuera un array
```csharp
var stringCollection = new SampleCollectionInt<string>();
stringCollection[0];
```

dentro de la clase debe tener un array y un indice
```csharp
private T[] arr = new T[100];
int nextIndex = 0;
```

la manera de acceder desde el objeto es nombreObjeto[/brackets/indice];
