# blackjack
unityとvuforiaを使って、biackjackをサポートするプログラムを作りました。現状だと、使えるカードは限られていますが、今後増やしていきたいと考えています。
使用環境
Unity2018.4．23f1
vuforia

一般的なトランプをマーカーとして使用し、認識した場合にはカードの合計値を計算しています。合計値によって次に取るべき手を示してくれます。

今後の課題
次の行動を示すプログラムが条件式による分岐なので、AIを導入して対応できる場面を増やしたい。
登録しているカードの種類が少ないので、すべてのカードに対応できるように追加していきたい。
プレイヤーのカードなのかディーラーのカードなのかを判別できるようにしたい。現状は一部のカードに座標での判別を実装済み