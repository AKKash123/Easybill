Imports System.Drawing.Printing
Public Class Form1

    Dim Customer_detailsTableAdapter2 As Object


    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JayguruDataSet2.Customer_details' table. You can move, or remove it, as needed.
        Me.Customer_detailsTableAdapter1.Fill(Me.JayguruDataSet2.Customer_details)
        'TODO: This line of code loads data into the 'JayguruDataSet1.Customer_details' table. You can move, or remove it, as needed.
        Me.Customer_detailsTableAdapter1.Fill(Me.JayguruDataSet2.Customer_details)
        'TODO: This line of code loads data into the 'JayguruDataSet.Customer_details' table. You can move, or remove it, as needed.
        Me.Customer_detailsTableAdapter1.Fill(Me.JayguruDataSet2.Customer_details)
        ComboBox1.Items.Add("Cleaning")
        ComboBox1.Items.Add("Re- calibration")
        ComboBox1.Items.Add("Fixing revate stamping plug")
        ComboBox1.Items.Add("Testing")
        ComboBox1.Items.Add("Service")
        ComboBox1.Items.Add("Repairing")
        ComboBox1.Items.Add("Other works")
    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CustomerdetailsBindingSource1.AddNew()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim PrintDoc As New PrintDocument
            AddHandler PrintDoc.PrintPage, AddressOf Me.PrintText
            PrintDoc.Print()
            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Beep()
        End Try
    End Sub
    Private Sub PrintText(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        ev.Graphics.DrawString(rtReceipt.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(0, 0))
        Try
            ev.Graphics.DrawString(rtReceipt.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(0, 0))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Beep()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a, b, c As Integer
        a = TextBox12.Text
        b = TextBox15.Text
        c = a + b
        MessageBox.Show(c, "Total Rs is")
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        CustomerdetailsBindingSource1.MoveNext()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            CustomerdetailsBindingSource1.EndEdit()
            Customer_detailsTableAdapter1.Update(JayguruDataSet2.Customer_details)
            MessageBox.Show("Data is saved ")

        Catch ex As Exception
            MessageBox.Show("Data is not saved yet any problem occur")
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        CustomerdetailsBindingSource1.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage


        Try
            e.Graphics.DrawString(rtReceipt.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(0, 0))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Beep()
        End Try
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        rtReceipt.Clear()

        rtReceipt.AppendText("=====================================================================================================================================================" + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + vbTab + "Cash Memo" + vbTab + vbTab + vbTab + "Mob:-9932022980/7872918933" + vbNewLine)
        rtReceipt.AppendText("----------------------------------------------------------------------------------------------------------------------------------------------------" + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "M/S JAY GURU ELECTRONICS" + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "NEW ALIPURDUAR, ALIPURDUAR   Licence- 860-R" + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "W.B. Govt. Approved Repair of Electronics Weighing Scale" + vbNewLine)
        rtReceipt.AppendText("----------------------------------------------------------------------------------------------------------------------------------------------------" + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + vbTab + vbTab + "Bill no:  " + vbTab + TextBox1.Text + vbTab + "Date: " + vbTab + DateTimePicker1.Text + vbTab + "Prop:- Ashesh Biswas" + vbNewLine)
        rtReceipt.AppendText("----------------------------------------------------------------------------------------------------------------------------------------------------" + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + vbTab + "Customer Details" + vbTab + vbTab + vbNewLine)
        rtReceipt.AppendText("----------------------------------------------------------------------------------------------------------------------------------------------------" + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Customer name:    " + vbTab + TextBox2.Text + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Customer address: " + vbTab + TextBox3.Text + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Customer mobile no: " + vbTab + TextBox4.Text + vbNewLine)
        rtReceipt.AppendText("----------------------------------------------------------------------------------------------------------------------------------------------------" + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Weighing Scale Details" + vbTab + vbTab + vbNewLine)
        rtReceipt.AppendText("----------------------------------------------------------------------------------------------------------------------------------------------------" + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Modelno:---->" + vbTab + TextBox5.Text + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Sl no:----> " + vbTab + TextBox6.Text + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Max:----> " + vbTab + TextBox7.Text + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Min:----> " + vbTab + TextBox8.Text + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "e:----> " + vbTab + TextBox9.Text + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Class:----> " + vbTab + TextBox10.Text + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Brand/Mfd.:----> " + vbTab + TextBox11.Text + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Govt. fees:----> " + vbTab + TextBox12.Text + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Details:----> " + vbTab + ComboBox1.Text + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Other Details:----> " + vbTab + TextBox16.Text + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Qnty:----> " + vbTab + TextBox13.Text + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Rate:----> " + vbTab + TextBox14.Text + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Paid:----> " + vbTab + TextBox20.Text + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Dew:----> " + vbTab + TextBox21.Text + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Amount:----> " + vbTab + TextBox15.Text + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Total:----> " + vbTab + TextBox17.Text + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Rupees(in word):----> " + vbTab + TextBox18.Text + "Only/-" + vbNewLine)
        rtReceipt.AppendText("----------------------------------------------------------------------------------------------------------------------------------------------------" + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "N.B :-No Gurantee / Warrantee on Repairing---- " + vbNewLine)
         rtReceipt.AppendText("----------------------------------------------------------------------------------------------------------------------------------------------------" + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Meet: 11 Hath Kalibari, beside Hotel Dooars mountain" + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + vbTab + "Thank you come once again" + vbTab + "Computerised bill no need any written signature" + vbNewLine)
        rtReceipt.AppendText("====================================================================================================================================================" + vbNewLine)
    End Sub

    Private Sub TextBox19_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
