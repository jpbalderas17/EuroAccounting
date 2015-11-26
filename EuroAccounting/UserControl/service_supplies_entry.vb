Public Class service_supplies_entry
    Dim db As New DBHelper(My.Settings.connectionString)
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand
    Public Function insert_to_journal(journal_data As IDictionary(Of String, Object), journal_entry_data As IDictionary(Of String, Object))

        Dim journal_input As New Dictionary(Of String, Object)
        Try


            '##BEGIN TRANSCTION

            '## INSERT INTO JOURNAL
            '## GET LAST INSERTED ID of journals
            journal_input.Add("journal_id", db.ExecuteScalar("INSERT INTO journals(date,description) VALUES(@date,@description);SELECT Scope_Identity()", journal_data).ToString)


            '##ORGANIZE input TO BE INSERTED AS JOURNAL ENTRIES
            '## GET account type 
            Select Case journal_entry_data("journal_type")
                Case "Purchase Supplies"
                    'journal_input.Add("account_type_id", 5)
                    Select Case journal_entry_data("payment_type")
                        Case "Cash"
                            '#DEBIT
                            journal_input.Add("account_type_id", 5)

                            journal_input.Add("amount", journal_entry_data("to_be_paid"))
                            db.ExecuteNonQuery("INSERT INTO journal_details(account_type_id,journal_id,is_debit,account_name,amount) VALUES(5,@journal_id,1,'Supplies',@amount)", journal_input)

                            '#CREDIT
                            journal_input("account_type_id") = 5
                            db.ExecuteNonQuery("INSERT INTO journal_details(account_type_id,journal_id,is_debit,account_name,amount) VALUES(@account_type_id,@journal_id,0,'Cash',@amount)", journal_input)

                        Case "Downpayment"
                            '#DEBIT
                            journal_input.Add("account_type_id", 5)

                            journal_input.Add("amount", journal_entry_data("to_be_paid"))
                            db.ExecuteNonQuery("INSERT INTO journal_details(account_type_id,journal_id,is_debit,account_name,amount) VALUES(5,@journal_id,1,'Supplies',@amount)", journal_input)




                            '#CREDIT
                            journal_input("account_type_id") = 6
                            journal_input("amount") = CDbl(journal_entry_data("to_be_paid")) - CDbl(journal_entry_data("paid"))
                            db.ExecuteNonQuery("INSERT INTO journal_details(account_type_id,journal_id,is_debit,account_name,amount) VALUES(@account_type_id,@journal_id,0,'Account Payables',@amount)", journal_input)

                            journal_input("account_type_id") = 5
                            journal_input("amount") = CDbl(journal_entry_data("paid"))
                            db.ExecuteNonQuery("INSERT INTO journal_details(account_type_id,journal_id,is_debit,account_name,amount) VALUES(@account_type_id,@journal_id,0,'Cash',@amount)", journal_input)
                        Case "On Account"
                            '#DEBIT
                            journal_input.Add("account_type_id", 5)

                            journal_input.Add("amount", journal_entry_data("to_be_paid"))
                            db.ExecuteNonQuery("INSERT INTO journal_details(account_type_id,journal_id,is_debit,account_name,amount) VALUES(5,@journal_id,1,'Supplies',@amount)", journal_input)

                            '#CREDIT
                            journal_input("account_type_id") = 6
                            journal_input("amount") = CDbl(journal_entry_data("to_be_paid")) - CDbl(journal_entry_data("paid"))
                            db.ExecuteNonQuery("INSERT INTO journal_details(account_type_id,journal_id,is_debit,account_name,amount) VALUES(@account_type_id,@journal_id,0,'Account Payables',@amount)", journal_input)
                    End Select
                Case "Payments"
                    'journal_input.Add("account_type_id", 3)
                Case "Service"

                    Select Case journal_entry_data("payment_type")
                        Case "Cash"
                            '#DEBIT
                            journal_input.Add("account_type_id", 5)

                            journal_input.Add("amount", journal_entry_data("to_be_paid"))
                            db.ExecuteNonQuery("INSERT INTO journal_details(account_type_id,journal_id,is_debit,account_name,amount) VALUES(5,@journal_id,1,'Cash',@amount)", journal_input)

                            '#CREDIT
                            journal_input("account_type_id") = 1
                            db.ExecuteNonQuery("INSERT INTO journal_details(account_type_id,journal_id,is_debit,account_name,amount) VALUES(@account_type_id,@journal_id,0,'Service Revenue',@amount)", journal_input)

                        Case "Downpayment"
                            '#DEBIT
                            journal_input.Add("account_type_id", 5)

                            journal_input.Add("amount", journal_entry_data("paid"))
                            db.ExecuteNonQuery("INSERT INTO journal_details(account_type_id,journal_id,is_debit,account_name,amount) VALUES(5,@journal_id,1,'Cash',@amount)", journal_input)

                            journal_input("amount") = CDbl(journal_entry_data("to_be_paid")) - CDbl(journal_entry_data("paid"))
                            db.ExecuteNonQuery("INSERT INTO journal_details(account_type_id,journal_id,is_debit,account_name,amount) VALUES(5,@journal_id,1,'Account Receivables',@amount)", journal_input)


                            '#CREDIT
                            journal_input("account_type_id") = 1
                            journal_input("amount") = journal_entry_data("to_be_paid")
                            db.ExecuteNonQuery("INSERT INTO journal_details(account_type_id,journal_id,is_debit,account_name,amount) VALUES(@account_type_id,@journal_id,0,'Service Revenue',@amount)", journal_input)
                        Case "On Account"
                            '#DEBIT
                            journal_input.Add("account_type_id", 5)

                            journal_input.Add("amount", journal_entry_data("to_be_paid"))
                            db.ExecuteNonQuery("INSERT INTO journal_details(account_type_id,journal_id,is_debit,account_name,amount) VALUES(5,@journal_id,1,'Account Receivables',@amount)", journal_input)
                            '#CREDIT
                            journal_input("account_type_id") = 1
                            db.ExecuteNonQuery("INSERT INTO journal_details(account_type_id,journal_id,is_debit,account_name,amount) VALUES(@account_type_id,@journal_id,0,'Service Revenue',@amount)", journal_input)
                    End Select
            End Select






            '##INSERT JOURNAL DETAILS


            '##FINISH TRANSACTION
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db.Dispose()
        End Try

        Return False

    End Function
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim journal_data As New Dictionary(Of String, Object)
        Dim journal_entry_data As New Dictionary(Of String, Object)
        journal_data.Add("date", dt_journal.Value)
        journal_data.Add("description", txt_description.Text)

        journal_entry_data.Add("to_be_paid", txt_amount_to_be_paid.Text)
        journal_entry_data.Add("payment_type", cbo_payment_type.Text)
        journal_entry_data.Add("paid", txt_amount_paid.Text)
        journal_entry_data.Add("journal_type", lbl_journal_type.Text)
        insert_to_journal(journal_data, journal_entry_data)
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        showUSC(uscMainMenu)
    End Sub
End Class
