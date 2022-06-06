Imports Entidad, Dato

Public Class clsGiftCardRegaloBI
    Dim giftCard As New clsGiftCardRegaloDA

    Public Function ListaGiftCard() As List(Of eGiftcardRegalo)
        Return giftCard.ListaGiftCard
    End Function
End Class
