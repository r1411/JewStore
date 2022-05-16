namespace JewStoreFS

type Ring(size:int16, name: string, weight: double, material: Material, materialSample: int16, gemData: Option<GemData>, price: double, article: int64, pictureURL: string) =
    inherit JewelryItemBase(name, weight, material, materialSample, gemData, price, article, pictureURL)
    member this.Size = size
    override this.ToString() = "Ring " + name.ToString() + " " + article.ToString() 