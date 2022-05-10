module JewelryItemBase

open Material
open GemData

[<AbstractClass>]
type JewelryItemBase(name: string, weight: double, material: Material, materialSample: int16, gemData: GemData, price: double, article: int64, pictureURL: string) =
    member this.Name = name
    member this.Weight = weight
    member this.Material = material
    member this.MaterialSample = materialSample
    member this.GemData = gemData
    member this.Price = price
    member this.Article = article
    member this.PictureURL = pictureURL