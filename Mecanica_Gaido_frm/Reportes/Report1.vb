<?xml version="1.0" encoding="utf-8"?>
<Report xmlns="http://schemas.telerik.com/reporting/2012/2" Width="6.5in" Name="Report1">
  <PageSettings>
    <PageSettings PaperKind="Letter" Landscape="False">
      <Margins>
        <MarginsU Left="1in" Right="1in" Top="1in" Bottom="1in" />
      </Margins>
    </PageSettings>
  </PageSettings>  
  <Items>
    <PageHeaderSection Height="1in" />
    <DetailSection Height="2in" />
    <PageFooterSection Height="1in" />
  </Items>
  <StyleSheet>
    <StyleRule>
      <Style>
        <Padding Left="2pt" Right="2pt" />
      </Style>
      <Selectors>
        <TypeSelector Type="TextItemBase" />
        <TypeSelector Type="HtmlTextBox" />
      </Selectors>
    </StyleRule>
  </StyleSheet>
</Report>