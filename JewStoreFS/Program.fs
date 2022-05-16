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

    let ring1 = new Ring(15s,"Кольцо из белого золота с бриллиантом",1.95,Material.WhiteGold,585s,Some {GemType = GemType.Diamond; GemCount = 1s;GemWeight = 0.028 },40000,10001,"https://pmdn.sokolov.io/pics/FD/31/238A78E75D5F3BD703BBD50A232D.jpg")
    let earring1 = new Earring(78s,true,"Серьги из серебра с фианитами",22.70,Material.Silver,585s,Some {GemType = GemType.CubicZirconia;GemCount=492s;GemWeight=1},18990,20001,"https://pmdn.sokolov.io/pics/F2/9A/D965BE48067E4A1805427A444B02.jpg")
    let chain1 = new Chain(50s,"Нонна",0.5,"Цепь из золота",3.69,Material.RedGold,585s,None,30000,30001,"https://pmdn.sokolov.io/pics/A0/19/79BDF85A41E1DFC20907B35EAD45.jpg")
    let watch1 = new Watch(34,150,false,"Женские стальные часы",199,Material.Steel,316s,None,6000,40001,"https://pmdn.sokolov.io/pics/D2/54/C0F8301F9FA65002280FAED9EC07.jpg")     

    let q = JsonConvert.SerializeObject(watch1)
    let qq = JsonConvert.DeserializeObject<Ring>(q)
    Console.WriteLine(q)

    0
