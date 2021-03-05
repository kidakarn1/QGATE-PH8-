Module Module1
    Dim V_permission = "NO_DATA"
    Dim V_user_id = "NO_DATA"
    Dim V_ref_id = "NO_DATA"
    Dim V_QR_PROM = "NO_DATA"
    Public Sub set_permission(permission As String)
        V_permission = permission
    End Sub
    Public Function get_permission()
        Return V_permission
    End Function
    Public Sub set_user_id(user_id As String)
        V_user_id = user_id
    End Sub
    Public Function get_user_id()
        Return V_user_id
    End Function
    Public Sub set_ref_id(ref_id As String)
        V_ref_id = ref_id
    End Sub
    Public Function get_ref_id()
        Return V_ref_id
    End Function
    Public Sub set_QR_PROM(QR_PROM As String)
        V_QR_PROM = QR_PROM
    End Sub
    Public Function get_QR_PROM()
        Return V_QR_PROM
    End Function
End Module