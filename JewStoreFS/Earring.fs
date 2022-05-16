namespace JewStoreFS

type Earring(length:int16, haslock:bool, name: string, weight: double, material: Material, materialSample: int16, gemData: Option<GemData>, price: double, article: int64, pictureURL: string) =
    inherit JewelryItemBase(name, weight, material, materialSample, gemData, price, article, pictureURL)
    member this.Length = length
    member this.HasLock = haslock
    override this.ToString() = "Earring " + name.ToString() + " " + article.ToString()

