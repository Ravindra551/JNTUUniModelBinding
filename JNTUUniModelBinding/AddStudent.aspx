<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="JNTUUniModelBinding.AddStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ValidationSummary runat="server" ShowModelStateErrors="true" />
    <asp:FormView runat="server" ID="addStudentForm"
        ItemType="JNTUUniModelBinding.Models.Student"
        InsertMethod="InsertStudent" DefaultMode="Insert"
        RenderOuterTable="false" OnItemInserted="addStudentForm_ItemInserted" OnCallingDataMethods="addStudentForm_CallingDataMethods">
        <InsertItemTemplate>
            <fieldset>
                <ol>
                    <asp:DynamicEntity runat="server" Mode="Insert" />
                </ol>
                <asp:Button runat="server" Text="Insert" CommandName="Insert" />
                <asp:Button runat="server" Text="Cancel" CausesValidation="false" OnClick="cancelButton_Click" />
            </fieldset>
        </InsertItemTemplate>
    </asp:FormView>
</asp:Content>
