﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ELE001.aspx.cs" Inherits="index" MasterPageFile="~/Site.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-header">Elétrica</div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div class="box box-header">
        <div class="box-body">
            <form id="form1" runat="server">
                <div class="row">
                    <div class="col-lg-4 form-group">
                        <label><%//= Resources.Resource.gastoEnergiaMes %></label>
                        <input id="gastoMes" type="text" class="form-control" disabled="disabled" value="800kW" />
                    </div>
                    <div class="col-lg-4 form-group">
                        <label><%//= Resources.Resource.gastoMedioHora %></label>
                        <input id="gastoHora" type="text" class="form-control" disabled="disabled" value="50kW/h" />
                    </div>
                    <div class="col-lg-4 form-group">
                        <label>teste</label>
                        <input id="col3" type="text" class="form-control" disabled="disabled" value="" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-4 form-group">
                        <label><%//= Resources.Resource.valorkW %></label>
                        <input id="11" type="text" class="form-control" disabled="disabled" value="0,22 R$/kW" />
                    </div>
                    <div class="col-lg-4 form-group">
                        <label><%//= Resources.Resource.gastoTotalMensal %></label>
                        <input id="22" type="text" class="form-control" disabled="disabled" value="R$176,00" />
                    </div>
                    <div class="col-lg-4 form-group">
                        <label>teste</label>
                        <input id="33" type="text" class="form-control" disabled="disabled" value="" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-4 form-group">
                        <label>test</label>
                        <input id="1" type="text" class="form-control" disabled="disabled" value="" />
                    </div>
                    <div class="col-lg-4 form-group">
                        <label>test</label>
                        <input id="2" type="text" class="form-control" disabled="disabled" value="" />
                    </div>
                    <div class="col-lg-4 form-group">
                        <label>teste</label>
                        <input id="3" type="text" class="form-control" disabled="disabled" value="" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <div class="tab-content no-padding">
                            <%--<div class="chart tab-pane active" id="revenue-chart" style="position: relative; height: 280px;"></div>--%>
                        </div>
                    </div>

                </div>
            </form>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
    <script type="text/javascript">
           
    </script>
</asp:Content>
