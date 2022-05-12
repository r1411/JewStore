module Watch


open GemData
open Material
open JewelryItemBase

type Watch(faceDiameter:double, bandLength:double,hasLights:bool, name: string, weight: double, material: Material, materialSample: int16, gemData: Option<GemData>, price: double, article: int64, pictureURL: string) =
    inherit JewelryItemBase(name, weight, material, materialSample, gemData, price, article, pictureURL)
    member this.FaceDiameter = faceDiameter
    member this.BandLength = bandLength
    member this.HasLights = hasLights
    override this.ToString() = "Watch " + name.ToString() + " " + article.ToString()

