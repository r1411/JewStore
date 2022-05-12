// Этот файл для тестов. В будущем скорее всего удалим его.

open Ring
open Earring
open Chain
open GemData
open GemType
open Material
open JewelryItemBase
open System
open Newtonsoft.Json

[<EntryPoint>]
let main argv =

    let ring1 = new Ring(15s,"Крутое кольцо",12.0,Material.Gold,585s,{GemType = GemType.Diamond; GemCount = 1s;GemWeight = 2 },50000,123123,"https://vk.com/tux")
    let earring1 = new Earring(78s,true,"Серьги из серебра с фианитами",22.70,Material.Silver,585s,{GemType = GemType.CubicZirconia;GemCount=492s;GemWeight=1},18990,20001,"https://pmdn.sokolov.io/pics/F2/9A/D965BE48067E4A1805427A444B02.jpg")
    let chain1 = new Chain(50s,"Нонна",0.5,"Цепь из золота",3.69,Material.RedGold,585s,{},30000,30001,"https://pmdn.sokolov.io/pics/A0/19/79BDF85A41E1DFC20907B35EAD45.jpg")

    let q = JsonConvert.SerializeObject(earring1)
    let qq = JsonConvert.DeserializeObject<Ring>(q)
    Console.WriteLine(q)

    0
