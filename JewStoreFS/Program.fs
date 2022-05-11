// Этот файл для тестов. В будущем скорее всего удалим его.

open Ring
open GemData
open GemType
open Material
open JewelryItemBase
open System

[<EntryPoint>]
let main argv =
    let g = {GemType = GemType.Diamond; GemCount = 1s;GemWeight = 2 }
    let r = new Ring(15s,"Крутое кольцо",12.0,Material.Gold,585s,{GemType = GemType.Diamond; GemCount = 1s;GemWeight = 2 },50000,123123,"https://vk.com/tux")
    Console.WriteLine(r)
    0
