namespace JewStoreFS


module FormatUtils =
    let MaterialToString = function
        | Gold -> "Золото"
        | WhiteGold -> "Белое золото"
        | RedGold -> "Красное золото"
        | Silver -> "Серебро"
        | Platinum -> "Платина"
        | Steel -> "Сталь"

    let GemTypeToString = function
        | Diamond -> "Бриллиант"
        | Emerald -> "Изумруд"
        | Ruby -> "Рубин"
        | CubicZirconia -> "Фианит"

