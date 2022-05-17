namespace JewStoreFS

open System.IO
open Newtonsoft.Json.Linq


type JsonDB(filePath: string) = 
    let jewItems:(JewelryItemBase list) =
        let rootObj = JObject.Parse(File.ReadAllText(filePath))
        let rings = rootObj["RINGS"].ToObject<Ring list>()
        let earrings = rootObj["EARRINGS"].ToObject<Earring list>()
        let chains = rootObj["CHAINS"].ToObject<Chain list>()
        let watches = rootObj["WATCHES"].ToObject<Watch list>()

        List.map (fun r -> upcast r) rings @ List.map (fun e -> upcast e) earrings @ List.map (fun c -> upcast c) chains @ List.map (fun w -> upcast w) watches
        

    member this.GetAllJewelry() =
        jewItems

    member this.GetRings() =
        List.filter (fun (item: JewelryItemBase) -> item :? Ring) jewItems

    member this.GetEarrings() =
        List.filter (fun (item: JewelryItemBase) -> item :? Earring) jewItems

    member this.GetChains() =
        List.filter (fun (item: JewelryItemBase) -> item :? Chain) jewItems

    member this.GetWatches() =
        List.filter (fun (item: JewelryItemBase) -> item :? Watch) jewItems

    member this.GetMostExpensiveRing() =
        let rings = this.GetRings()
        List.maxBy(fun (item:JewelryItemBase)->item.Price) rings

    member this.GetMostThickChain() =
        let chainlist = this.GetChains()
        let chains = List.map(fun (item:JewelryItemBase) -> item :?> Chain) chainlist
        List.maxBy(fun (item:Chain)->item.WireThickness ) chains

    member this.GetMostShortEarring() =
        let earringslist = this.GetEarrings()
        let earrings = List.map(fun(item:JewelryItemBase)->item:?>Earring) earringslist
        List.minBy(fun(item:Earring)->item.Length) earrings

    static member Sorted(items: (JewelryItemBase list), sortingFunction) =
        List.sortWith sortingFunction items

    