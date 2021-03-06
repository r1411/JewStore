namespace JewStoreFS

type Chain(size:int16, weavingName:string,wireThickness:double, name: string, weight: double, material: Material, materialSample: int16, gemData: Option<GemData>, price: double, article: int64, pictureURL: string) =
    inherit JewelryItemBase(name, weight, material, materialSample, gemData, price, article, pictureURL)
    member this.Size = size
    member this.WeavingName = weavingName
    member this.WireThickness = wireThickness
    override this.ToString() = "Chain " + name.ToString() + " " + article.ToString()

