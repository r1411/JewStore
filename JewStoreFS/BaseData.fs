module BaseData

open Ring
open Earring
open Chain
open Watch


open Newtonsoft.Json
open System
open System.IO
open Newtonsoft.Json.Linq
open System.Collections

type BaseData() =
    let mutable Rings = List<Ring>.Empty
    let mutable Earrings = List<Earring>.Empty
    let mutable Chains = List<Chain>.Empty
    let mutable Watches = List<Watch>.Empty
    member this.Jsonpath = @"C:\Users\kirya\source\repos\JewStore\JewStoreFS\Resources\Json10LR.json"
    member this.getRings
        with get() = Rings
    member this.getEarrings
        with get() = Earrings
    member this.getChains
        with get() = Chains
    member this.getWatches
        with get() = Watches

    member this.jewelry_form () = 
        let obj1 = JObject.Parse(File.ReadAllText(this.Jsonpath))
        Rings <- obj1["RINGS"].ToObject<List<Ring>>()
        Earrings <- obj1["EARRINGS"].ToObject<List<Earring>>()
        Chains <-obj1["CHAINS"].ToObject<List<Chain>>()
        Watches <-obj1["WATCHES"].ToObject<List<Watch>>()

        
        