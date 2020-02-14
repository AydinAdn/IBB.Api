# IBB.Api
A .NET client library for [IETT IBB Web Services](https://data.ibb.gov.tr/dataset/iett-ibb-web-servisi). 

It abstracts away the messy SOAP api, and is essentially just a facade.


## Examples

### GetDurakAsync

```csharp
IbbClient client = new IbbClient();
IEnumerable<DurakResponse> result = await client.GetDurakAsync();

```

|DurakKodu|DurakAdi|Koordinat|IlceAdi|Yon|Akilli|Fiziki|DurakTipi|
|---|---|---|---|---|---|---|---|
|225972|MERCAN YUVASI|POINT (29.2763499999941 40.8183030005252)|Tuzla|SON DURAK|YOK|AÇIK|İETTBAYRAK|
|225981|DENİZ HARP OKULU|POINT (29.266183999994 40.8140130005245)|Tuzla|TUZLA|YOK|FULL KAPALI|CCMODERN|
|227161|ŞEKER SOKAK|POINT (29.3429089999946 40.8837970005355)|Tuzla|TEPEÖREN|YOK|AÇIK|AÇIK DURAK|
|...|...|...|...|...|...|...|...|


### GetDurakDetayAsync

```csharp
IbbClient client = new IbbClient();
IEnumerable<DurakDetayResponse> result = await client.GetDurakDetayAsync();
```

|HatKodu|Yon|SiraNo|DurakKodu|DurakAdi|KoordinatX|KoordinatY|Koordinat|DurakTipi|IsletmeBolge|IsletmeAltBolge|IlceAdi|
|---|---|---|---|---|---|---|---|---|---|---|---|
|AND2Y|G|1|210141|YUNUS GARAJI|29,206028|40,889562|40889562 29206028|AÇIK DURAK|Anadolu2|Pendik|Kartal|
|AND2Y|G|2|210142|YUNUS GARAJI|29,206019|40,889730|40889730 29206019|İETTBAYRAK|Anadolu2|Pendik|Kartal|
|AVR1|G|1|123941|İETT İKİTELLİ GARAJI|28,791210|41,058277|41058277 28791210|CCMODERN|Avrupa1|Başakşehir|Küçükçekmece|
|...|...|...|...|...|...|...|...|...|...|...|...|

### GetGarajAsync

```csharp
IbbClient client = new IbbClient();
IEnumerable<GarajResponse> result = await client.GetGarajAsync();
```

|Id|GarajAdi|GarajKodu|Koordinat|
|---|---|---|---|
|1|YUNUSGARAJI|PG_YUN|POINT (433119.174488398 4528573.62007664)|
|2|AVCILARGARAJI|G_AVC|POINT (392767.710359689 4539561.58527674)|
|3|AYAZAĞA(PARK)|PG_AYZ|POINT (413845.938678522 4553457.19050363)|
|...|...|...|...|

### GetHatServisAsync

```csharp
IbbClient client = new IbbClient();
IEnumerable<HatServisResponse> result = await client.GetHatServisAsync();
```

|HatKodu|HatAdi|TamHatAdi|HatDurumu|Bolge|
|---|---|---|---|---|
|AND1A|ANADOLU1 / ANADOLU|AND1A/ANADOLU1 / ANADOLU|1|Anadolu1|
|AND1A3|ANADOLU1 DEPAR / ANADOLU|AND1A3/ANADOLU1 DEPAR / ANADOLU|1|Anadolu2|
|AND1Ş|ANADOLU1 DEPAR / ŞAHİNKAYA|AND1Ş/ANADOLU1 DEPAR / ŞAHİNKAYA|1|Anadolu1|
|...|...|...|...|...|

### GetKazaLokasyonAsync

```csharp
IbbClient client = new IbbClient();
IEnumerable<KazaLokasyonResponse> result = await client.GetKazaLokasyonAsync(DateTime.Now.AddDays(-1));
```
|BaslangicZamani|Boylam|Enlem|Tur|
|---|---|---|---|
|10/02/2020 21:00:00|29.066029|41.07605|Kaza|
|10/02/2020 21:00:00|28.677408|41.040035|Kaza|
|10/02/2020 21:00:00|29.064054|40.982937|Kaza|
|...|...|...|...|

### GetAracKonumlariAsync

```csharp
IbbClient client = new IbbClient();
IEnumerable<AracKonumuResponse> result = await client.GetAracKonumlariAsync();
```

|Operator|Garaj|KapiNo|Saat|Boylam|Enlem|Hiz|Plaka|
|---|---|---|---|---|---|---|---|
|İETT|G_IKT|B5308|14/02/2020 04:09:00|28.791178|41.06148|0|34 NL 8219|
|İETT|G_IKT|B5323|14/02/2020 04:09:00|28.791714|41.06135|0|34 NL 8204|
|İETT|PG_TPK|B5338|14/02/2020 04:09:00|28.928572|41.016937|0|34 NL 8197|
|...|...|...|...|...|...|...|...|

---------------

### Subscribe to updates on the `GetAracKonumlariAsync` endpoint

You can also subscribe to the location data. The data isn't *live* in the sense that it isn't streamed from anywhere, the service is simply executing the `GetAracKonumlariAsync` endpoint every minute behind the scenes, essentially polling for new data. 
Data returned from the API is compared to data stored in an internal cache, if any new data is present, an event is raised containing the updates. 

The cache service is not a data store. It's only used to present the client with updates on new data, and also to ignore data that's been received late and is out of order (due to newer items existing).

```csharp
    CancellationTokenSource cts = new CancellationTokenSource(TimeSpan.FromMinutes(60));
    IbbClient client = new IbbClient();
    
    // The cache service raises events notifying the client of new data.
    // It also ensures that data that's received out of order is ignored.
    AracKonumCacheService cacheService = new AracKonumCacheService(client);
    
    cacheService.OnAracKonumUpdate += (sender, data) => 
    {
        // The event arguments contains a collection of all the updated data.
        // The updated elements are batched together.
        IEnumerable<AracKonumuResponse> updatedData = data.UpdatedAracKonumlari;
        Console.WriteLine($"Elements updated: {updatedData.Count()}");
    };
    
    await cacheService.BeginTracking(cts.Token);
```

