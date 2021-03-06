﻿// Developer Express Code Central Example:
// How to generate a document layout in code via the Snap application programming interface (API)
// 
// This example illustrates the Snap API
// (https://documentation.devexpress.com/#WindowsForms/CustomDocument14525) that is
// used to generate a document from scratch and connect it to data completely in
// code.
// The following code generates a tabular report layout. For a sample code
// that creates a mail-merge report (in the context of SnapDocumentServer
// (https://documentation.devexpress.com/#DocumentServer/clsDevExpressSnapSnapDocumentServertopic)),
// refer to the following example: How to automatically create mail-merge documents
// using the Snap Document Server
// (https://www.devexpress.com/Support/Center/CodeCentral/ViewExample.aspx?exampleId=E5078).
// SnapControl
// (https://documentation.devexpress.com/#WindowsForms/clsDevExpressSnapSnapControltopic)
// extends the RichEditControl
// (https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraRichEditRichEditControltopic)'s
// API and introduces the SnapList
// (http://documentation.devexpress.com/#WindowsForms/clsDevExpressSnapCoreAPISnapListtopic)
// class that is used to insert dynamic data elements into a document.
// To generate
// a data-aware Snap document, do the following:
// - Create a Snap application and
// connect it to a data source
// (http://documentation.devexpress.com/#WindowsForms/CustomDocument16043).
// - Add
// a SnapList to the SnapDocument
// (http://documentation.devexpress.com/#WindowsForms/clsDevExpressSnapCoreAPISnapDocumenttopic).
// -
// To generate the SnapList layout, define the ListHeader, ListFooter, and
// RowTemplate
// (http://documentation.devexpress.com/#WindowsForms/DevExpressSnapCoreAPISnapList_RowTemplatetopic).
// - Inject data fields
// (http://documentation.devexpress.com/#WindowsForms/CustomDocument15559) into the
// document (e.g., by using SnapText to display text data).
// - Format the document
// content (see the FormatList method implementation in the Form1.cs file of the
// sample solution).
// - If required, apply grouping, sorting, and/or filtering to
// the SnapList content.
// A SnapEntity
// (http://documentation.devexpress.com/#WindowsForms/clsDevExpressSnapCoreAPISnapEntitytopic)
// is open to customization only after calling its BeginUpdate method and not after
// the EndUpdate method is called to apply the new settings (see the GenerateLayout
// method in the Form1.cs file of the sample solution).
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4781

namespace Snap_API {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup3 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraRichEdit.Model.BorderInfo borderInfo1 = new DevExpress.XtraRichEdit.Model.BorderInfo();
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation1 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            this.stylesRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup();
            this.galleryChangeStyleItem1 = new DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem();
            this.snapControl1 = new DevExpress.Snap.SnapControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.fileNewItem1 = new DevExpress.XtraRichEdit.UI.FileNewItem();
            this.fileOpenItem1 = new DevExpress.XtraRichEdit.UI.FileOpenItem();
            this.fileSaveItem1 = new DevExpress.XtraRichEdit.UI.FileSaveItem();
            this.fileSaveAsItem1 = new DevExpress.XtraRichEdit.UI.FileSaveAsItem();
            this.commandBarItem1 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.quickPrintItem1 = new DevExpress.XtraRichEdit.UI.QuickPrintItem();
            this.printItem1 = new DevExpress.XtraRichEdit.UI.PrintItem();
            this.printPreviewItem1 = new DevExpress.XtraRichEdit.UI.PrintPreviewItem();
            this.undoItem1 = new DevExpress.XtraRichEdit.UI.UndoItem();
            this.redoItem1 = new DevExpress.XtraRichEdit.UI.RedoItem();
            this.commandBarItem2 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.pasteItem1 = new DevExpress.XtraRichEdit.UI.PasteItem();
            this.cutItem1 = new DevExpress.XtraRichEdit.UI.CutItem();
            this.copyItem1 = new DevExpress.XtraRichEdit.UI.CopyItem();
            this.pasteSpecialItem1 = new DevExpress.XtraRichEdit.UI.PasteSpecialItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.changeFontNameItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontNameItem();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.changeFontSizeItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontSizeItem();
            this.repositoryItemRichEditFontSizeEdit1 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit();
            this.fontSizeIncreaseItem1 = new DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem();
            this.fontSizeDecreaseItem1 = new DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem();
            this.barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            this.toggleFontBoldItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontBoldItem();
            this.toggleFontItalicItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontItalicItem();
            this.toggleFontUnderlineItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem();
            this.toggleFontDoubleUnderlineItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem();
            this.toggleFontStrikeoutItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem();
            this.toggleFontDoubleStrikeoutItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem();
            this.toggleFontSuperscriptItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem();
            this.toggleFontSubscriptItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem();
            this.barButtonGroup3 = new DevExpress.XtraBars.BarButtonGroup();
            this.changeFontColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontColorItem();
            this.changeFontBackColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem();
            this.changeTextCaseItem1 = new DevExpress.XtraRichEdit.UI.ChangeTextCaseItem();
            this.makeTextUpperCaseItem1 = new DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem();
            this.makeTextLowerCaseItem1 = new DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem();
            this.toggleTextCaseItem1 = new DevExpress.XtraRichEdit.UI.ToggleTextCaseItem();
            this.clearFormattingItem1 = new DevExpress.XtraRichEdit.UI.ClearFormattingItem();
            this.barButtonGroup4 = new DevExpress.XtraBars.BarButtonGroup();
            this.toggleBulletedListItem1 = new DevExpress.XtraRichEdit.UI.ToggleBulletedListItem();
            this.toggleNumberingListItem1 = new DevExpress.XtraRichEdit.UI.ToggleNumberingListItem();
            this.toggleMultiLevelListItem1 = new DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem();
            this.barButtonGroup5 = new DevExpress.XtraBars.BarButtonGroup();
            this.decreaseIndentItem1 = new DevExpress.XtraRichEdit.UI.DecreaseIndentItem();
            this.increaseIndentItem1 = new DevExpress.XtraRichEdit.UI.IncreaseIndentItem();
            this.toggleShowWhitespaceItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem();
            this.barButtonGroup6 = new DevExpress.XtraBars.BarButtonGroup();
            this.toggleParagraphAlignmentLeftItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem();
            this.toggleParagraphAlignmentCenterItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem();
            this.toggleParagraphAlignmentRightItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem();
            this.toggleParagraphAlignmentJustifyItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem();
            this.barButtonGroup7 = new DevExpress.XtraBars.BarButtonGroup();
            this.changeParagraphLineSpacingItem1 = new DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem();
            this.setSingleParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem();
            this.setSesquialteralParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem();
            this.setDoubleParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem();
            this.showLineSpacingFormItem1 = new DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem();
            this.addSpacingBeforeParagraphItem1 = new DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem();
            this.removeSpacingBeforeParagraphItem1 = new DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem();
            this.addSpacingAfterParagraphItem1 = new DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem();
            this.removeSpacingAfterParagraphItem1 = new DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem();
            this.changeParagraphBackColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem();
            this.findItem1 = new DevExpress.XtraRichEdit.UI.FindItem();
            this.replaceItem1 = new DevExpress.XtraRichEdit.UI.ReplaceItem();
            this.insertPageBreakItem1 = new DevExpress.XtraRichEdit.UI.InsertPageBreakItem();
            this.insertTableItem1 = new DevExpress.XtraRichEdit.UI.InsertTableItem();
            this.insertPictureItem1 = new DevExpress.XtraRichEdit.UI.InsertPictureItem();
            this.insertFloatingPictureItem1 = new DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem();
            this.commandBarItem3 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.commandBarItem4 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.commandBarItem5 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.insertBookmarkItem1 = new DevExpress.XtraRichEdit.UI.InsertBookmarkItem();
            this.insertHyperlinkItem1 = new DevExpress.XtraRichEdit.UI.InsertHyperlinkItem();
            this.editPageHeaderItem1 = new DevExpress.XtraRichEdit.UI.EditPageHeaderItem();
            this.editPageFooterItem1 = new DevExpress.XtraRichEdit.UI.EditPageFooterItem();
            this.insertPageNumberItem1 = new DevExpress.XtraRichEdit.UI.InsertPageNumberItem();
            this.insertPageCountItem1 = new DevExpress.XtraRichEdit.UI.InsertPageCountItem();
            this.insertTextBoxItem1 = new DevExpress.XtraRichEdit.UI.InsertTextBoxItem();
            this.insertSymbolItem1 = new DevExpress.XtraRichEdit.UI.InsertSymbolItem();
            this.changeSectionPageMarginsItem1 = new DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem();
            this.setNormalSectionPageMarginsItem1 = new DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem();
            this.setNarrowSectionPageMarginsItem1 = new DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem();
            this.setModerateSectionPageMarginsItem1 = new DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem();
            this.setWideSectionPageMarginsItem1 = new DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem();
            this.showPageMarginsSetupFormItem1 = new DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem();
            this.changeSectionPageOrientationItem1 = new DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem();
            this.setPortraitPageOrientationItem1 = new DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem();
            this.setLandscapePageOrientationItem1 = new DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem();
            this.changeSectionPaperKindItem1 = new DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem();
            this.changeSectionColumnsItem1 = new DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem();
            this.setSectionOneColumnItem1 = new DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem();
            this.setSectionTwoColumnsItem1 = new DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem();
            this.setSectionThreeColumnsItem1 = new DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem();
            this.showColumnsSetupFormItem1 = new DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem();
            this.insertBreakItem1 = new DevExpress.XtraRichEdit.UI.InsertBreakItem();
            this.insertColumnBreakItem1 = new DevExpress.XtraRichEdit.UI.InsertColumnBreakItem();
            this.insertSectionBreakNextPageItem1 = new DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem();
            this.insertSectionBreakEvenPageItem1 = new DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem();
            this.insertSectionBreakOddPageItem1 = new DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem();
            this.changeSectionLineNumberingItem1 = new DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem();
            this.setSectionLineNumberingNoneItem1 = new DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem();
            this.setSectionLineNumberingContinuousItem1 = new DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem();
            this.setSectionLineNumberingRestartNewPageItem1 = new DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem();
            this.setSectionLineNumberingRestartNewSectionItem1 = new DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem();
            this.toggleParagraphSuppressLineNumbersItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem();
            this.showLineNumberingFormItem1 = new DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem();
            this.changePageColorItem1 = new DevExpress.XtraRichEdit.UI.ChangePageColorItem();
            this.switchToSimpleViewItem1 = new DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem();
            this.switchToDraftViewItem1 = new DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem();
            this.switchToPrintLayoutViewItem1 = new DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem();
            this.toggleShowHorizontalRulerItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem();
            this.toggleShowVerticalRulerItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem();
            this.zoomOutItem1 = new DevExpress.XtraRichEdit.UI.ZoomOutItem();
            this.zoomInItem1 = new DevExpress.XtraRichEdit.UI.ZoomInItem();
            this.snapBarToolbarsListItem1 = new DevExpress.Snap.Extensions.UI.SnapBarToolbarsListItem();
            this.commandBarCheckItem1 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.showAllFieldCodesItem1 = new DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem();
            this.showAllFieldResultsItem1 = new DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem();
            this.toggleFieldHighlightingItem1 = new DevExpress.Snap.Extensions.UI.ToggleFieldHighlightingItem();
            this.goToPageHeaderItem1 = new DevExpress.XtraRichEdit.UI.GoToPageHeaderItem();
            this.goToPageFooterItem1 = new DevExpress.XtraRichEdit.UI.GoToPageFooterItem();
            this.goToNextHeaderFooterItem1 = new DevExpress.XtraRichEdit.UI.GoToNextHeaderFooterItem();
            this.goToPreviousHeaderFooterItem1 = new DevExpress.XtraRichEdit.UI.GoToPreviousHeaderFooterItem();
            this.toggleLinkToPreviousItem1 = new DevExpress.XtraRichEdit.UI.ToggleLinkToPreviousItem();
            this.toggleDifferentFirstPageItem1 = new DevExpress.XtraRichEdit.UI.ToggleDifferentFirstPageItem();
            this.toggleDifferentOddAndEvenPagesItem1 = new DevExpress.XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem();
            this.closePageHeaderFooterItem1 = new DevExpress.XtraRichEdit.UI.ClosePageHeaderFooterItem();
            this.toggleFirstRowItem1 = new DevExpress.XtraRichEdit.UI.ToggleFirstRowItem();
            this.toggleLastRowItem1 = new DevExpress.XtraRichEdit.UI.ToggleLastRowItem();
            this.toggleBandedRowsItem1 = new DevExpress.XtraRichEdit.UI.ToggleBandedRowsItem();
            this.toggleFirstColumnItem1 = new DevExpress.XtraRichEdit.UI.ToggleFirstColumnItem();
            this.toggleLastColumnItem1 = new DevExpress.XtraRichEdit.UI.ToggleLastColumnItem();
            this.toggleBandedColumnsItem1 = new DevExpress.XtraRichEdit.UI.ToggleBandedColumnsItem();
            this.galleryChangeTableStyleItem1 = new DevExpress.XtraRichEdit.UI.GalleryChangeTableStyleItem();
            this.galleryChangeTableCellStyleItem1 = new DevExpress.Snap.Extensions.UI.GalleryChangeTableCellStyleItem();
            this.changeTableBorderLineStyleItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem();
            this.repositoryItemBorderLineStyle1 = new DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle();
            this.changeTableBorderLineWeightItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem();
            this.repositoryItemBorderLineWeight1 = new DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight();
            this.changeTableBorderColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem();
            this.changeTableBordersItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableBordersItem();
            this.toggleTableCellsBottomBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem();
            this.toggleTableCellsTopBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem();
            this.toggleTableCellsLeftBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem();
            this.toggleTableCellsRightBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem();
            this.resetTableCellsAllBordersItem1 = new DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem();
            this.toggleTableCellsAllBordersItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem();
            this.toggleTableCellsOutsideBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem();
            this.toggleTableCellsInsideBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem();
            this.toggleTableCellsInsideHorizontalBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem();
            this.toggleTableCellsInsideVerticalBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem();
            this.toggleShowTableGridLinesItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem();
            this.changeTableCellsShadingItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem();
            this.selectTableElementsItem1 = new DevExpress.XtraRichEdit.UI.SelectTableElementsItem();
            this.selectTableCellItem1 = new DevExpress.XtraRichEdit.UI.SelectTableCellItem();
            this.selectTableColumnItem1 = new DevExpress.XtraRichEdit.UI.SelectTableColumnItem();
            this.selectTableRowItem1 = new DevExpress.XtraRichEdit.UI.SelectTableRowItem();
            this.selectTableItem1 = new DevExpress.XtraRichEdit.UI.SelectTableItem();
            this.showTablePropertiesFormItem1 = new DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem();
            this.deleteTableElementsItem1 = new DevExpress.XtraRichEdit.UI.DeleteTableElementsItem();
            this.showDeleteTableCellsFormItem1 = new DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem();
            this.deleteTableColumnsItem1 = new DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem();
            this.deleteTableRowsItem1 = new DevExpress.XtraRichEdit.UI.DeleteTableRowsItem();
            this.deleteTableItem1 = new DevExpress.XtraRichEdit.UI.DeleteTableItem();
            this.insertTableRowAboveItem1 = new DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem();
            this.insertTableRowBelowItem1 = new DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem();
            this.insertTableColumnToLeftItem1 = new DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem();
            this.insertTableColumnToRightItem1 = new DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem();
            this.mergeTableCellsItem1 = new DevExpress.XtraRichEdit.UI.MergeTableCellsItem();
            this.showSplitTableCellsForm1 = new DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm();
            this.splitTableItem1 = new DevExpress.XtraRichEdit.UI.SplitTableItem();
            this.toggleTableAutoFitItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem();
            this.toggleTableAutoFitContentsItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem();
            this.toggleTableAutoFitWindowItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem();
            this.toggleTableFixedColumnWidthItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem();
            this.toggleTableCellsTopLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem();
            this.toggleTableCellsMiddleLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem();
            this.toggleTableCellsBottomLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem();
            this.toggleTableCellsTopCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem();
            this.toggleTableCellsMiddleCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem();
            this.toggleTableCellsBottomCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem();
            this.toggleTableCellsTopRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem();
            this.toggleTableCellsMiddleRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem();
            this.toggleTableCellsBottomRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem();
            this.showTableOptionsFormItem1 = new DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem();
            this.checkSpellingItem1 = new DevExpress.XtraRichEdit.UI.CheckSpellingItem();
            this.insertTableOfContentsItem1 = new DevExpress.XtraRichEdit.UI.InsertTableOfContentsItem();
            this.updateTableOfContentsItem1 = new DevExpress.XtraRichEdit.UI.UpdateTableOfContentsItem();
            this.addParagraphsToTableOfContentItem1 = new DevExpress.XtraRichEdit.UI.AddParagraphsToTableOfContentItem();
            this.setParagraphHeadingLevelItem1 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            this.setParagraphHeadingLevelItem2 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            this.setParagraphHeadingLevelItem3 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            this.setParagraphHeadingLevelItem4 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            this.setParagraphHeadingLevelItem5 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            this.setParagraphHeadingLevelItem6 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            this.setParagraphHeadingLevelItem7 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            this.setParagraphHeadingLevelItem8 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            this.setParagraphHeadingLevelItem9 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            this.setParagraphHeadingLevelItem10 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            this.insertCaptionPlaceholderItem1 = new DevExpress.XtraRichEdit.UI.InsertCaptionPlaceholderItem();
            this.insertFiguresCaptionItems1 = new DevExpress.XtraRichEdit.UI.InsertFiguresCaptionItems();
            this.insertTablesCaptionItems1 = new DevExpress.XtraRichEdit.UI.InsertTablesCaptionItems();
            this.insertEquationsCaptionItems1 = new DevExpress.XtraRichEdit.UI.InsertEquationsCaptionItems();
            this.insertTableOfFiguresPlaceholderItem1 = new DevExpress.XtraRichEdit.UI.InsertTableOfFiguresPlaceholderItem();
            this.insertTableOfFiguresItems1 = new DevExpress.XtraRichEdit.UI.InsertTableOfFiguresItems();
            this.insertTableOfTablesItems1 = new DevExpress.XtraRichEdit.UI.InsertTableOfTablesItems();
            this.insertTableOfEquationsItems1 = new DevExpress.XtraRichEdit.UI.InsertTableOfEquationsItems();
            this.updateTableOfFiguresItem1 = new DevExpress.XtraRichEdit.UI.UpdateTableOfFiguresItem();
            this.changeFloatingObjectFillColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFloatingObjectFillColorItem();
            this.changeFloatingObjectOutlineColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineColorItem();
            this.changeFloatingObjectOutlineWeightItem1 = new DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineWeightItem();
            this.repositoryItemFloatingObjectOutlineWeight1 = new DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight();
            this.changeFloatingObjectTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.ChangeFloatingObjectTextWrapTypeItem();
            this.setFloatingObjectSquareTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectSquareTextWrapTypeItem();
            this.setFloatingObjectTightTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectTightTextWrapTypeItem();
            this.setFloatingObjectThroughTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectThroughTextWrapTypeItem();
            this.setFloatingObjectTopAndBottomTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectTopAndBottomTextWrapTypeItem();
            this.setFloatingObjectBehindTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectBehindTextWrapTypeItem();
            this.setFloatingObjectInFrontOfTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectInFrontOfTextWrapTypeItem();
            this.changeFloatingObjectAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ChangeFloatingObjectAlignmentItem();
            this.setFloatingObjectTopLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectTopLeftAlignmentItem();
            this.setFloatingObjectTopCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectTopCenterAlignmentItem();
            this.setFloatingObjectTopRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectTopRightAlignmentItem();
            this.setFloatingObjectMiddleLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleLeftAlignmentItem();
            this.setFloatingObjectMiddleCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleCenterAlignmentItem();
            this.setFloatingObjectMiddleRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleRightAlignmentItem();
            this.setFloatingObjectBottomLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomLeftAlignmentItem();
            this.setFloatingObjectBottomCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomCenterAlignmentItem();
            this.setFloatingObjectBottomRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomRightAlignmentItem();
            this.floatingObjectBringForwardSubItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardSubItem();
            this.floatingObjectBringForwardItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardItem();
            this.floatingObjectBringToFrontItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectBringToFrontItem();
            this.floatingObjectBringInFrontOfTextItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectBringInFrontOfTextItem();
            this.floatingObjectSendBackwardSubItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardSubItem();
            this.floatingObjectSendBackwardItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardItem();
            this.floatingObjectSendToBackItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectSendToBackItem();
            this.floatingObjectSendBehindTextItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectSendBehindTextItem();
            this.themesGalleryBarItem1 = new DevExpress.Snap.Extensions.UI.ThemesGalleryBarItem();
            this.commandBarCheckItem2 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem3 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem4 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarSubItem1 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            this.commandBarCheckItem5 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem6 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem7 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem8 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem9 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.filterPopupButtonItem1 = new DevExpress.Snap.Extensions.UI.FilterPopupButtonItem();
            this.propertiesBarButtonItem1 = new DevExpress.Snap.Extensions.UI.PropertiesBarButtonItem();
            this.commandBarSubItem2 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            this.commandBarCheckItem10 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem11 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarSubItem3 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            this.commandBarCheckItem12 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem13 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarItem6 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.commandBarItem7 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.commandBarSubItem4 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            this.commandBarCheckItem14 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem15 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem16 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem17 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem18 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem19 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem20 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarSubItem5 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            this.commandBarCheckItem21 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem22 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarSubItem6 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            this.commandBarCheckItem23 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem24 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarItem8 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.commandBarItem9 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.commandBarSubItem7 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            this.commandBarCheckItem25 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem26 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem27 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem28 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem29 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem30 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem31 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarItem10 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.barButtonGroup8 = new DevExpress.XtraBars.BarButtonGroup();
            this.changeEditorRowLimitItem1 = new DevExpress.Snap.Extensions.UI.ChangeEditorRowLimitItem();
            this.repositoryItemEditorRowLimitEdit1 = new DevExpress.Snap.Design.RepositoryItemEditorRowLimitEdit();
            this.createBarBaseItem1 = new DevExpress.XtraCharts.UI.CreateBarBaseItem();
            this.createLineBaseItem1 = new DevExpress.XtraCharts.UI.CreateLineBaseItem();
            this.createPieBaseItem1 = new DevExpress.XtraCharts.UI.CreatePieBaseItem();
            this.createRotatedBarBaseItem1 = new DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem();
            this.createAreaBaseItem1 = new DevExpress.XtraCharts.UI.CreateAreaBaseItem();
            this.createOtherSeriesTypesBaseItem1 = new DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem();
            this.changePaletteGalleryBaseItem1 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem();
            this.changeAppearanceGalleryBaseItem1 = new DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseItem();
            this.runWizardChartItem1 = new DevExpress.XtraCharts.UI.RunWizardChartItem();
            this.headerFooterToolsRibbonPageCategory1 = new DevExpress.XtraRichEdit.UI.HeaderFooterToolsRibbonPageCategory();
            this.headerFooterToolsDesignRibbonPage1 = new DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignRibbonPage();
            this.headerFooterToolsDesignNavigationRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignNavigationRibbonPageGroup();
            this.headerFooterToolsDesignOptionsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignOptionsRibbonPageGroup();
            this.headerFooterToolsDesignCloseRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignCloseRibbonPageGroup();
            this.tableToolsRibbonPageCategory1 = new DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory();
            this.tableDesignRibbonPage1 = new DevExpress.XtraRichEdit.UI.TableDesignRibbonPage();
            this.tableStyleOptionsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableStyleOptionsRibbonPageGroup();
            this.tableStylesRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup();
            this.tableCellStylesRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.TableCellStylesRibbonPageGroup();
            this.tableDrawBordersRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup();
            this.tableLayoutRibbonPage1 = new DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage();
            this.tableTableRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup();
            this.tableRowsAndColumnsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup();
            this.tableMergeRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup();
            this.tableCellSizeRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup();
            this.tableAlignmentRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup();
            this.floatingPictureToolsRibbonPageCategory1 = new DevExpress.XtraRichEdit.UI.FloatingPictureToolsRibbonPageCategory();
            this.floatingPictureToolsFormatPage1 = new DevExpress.XtraRichEdit.UI.FloatingPictureToolsFormatPage();
            this.floatingPictureToolsShapeStylesPageGroup1 = new DevExpress.XtraRichEdit.UI.FloatingPictureToolsShapeStylesPageGroup();
            this.floatingPictureToolsArrangePageGroup1 = new DevExpress.XtraRichEdit.UI.FloatingPictureToolsArrangePageGroup();
            this.dataToolsRibbonPageCategory1 = new DevExpress.Snap.Extensions.UI.DataToolsRibbonPageCategory();
            this.appearanceRibbonPage1 = new DevExpress.Snap.Extensions.UI.AppearanceRibbonPage();
            this.themesRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.ThemesRibbonPageGroup();
            this.snMergeFieldToolsRibbonPage1 = new DevExpress.Snap.Extensions.UI.SNMergeFieldToolsRibbonPage();
            this.dataShapingRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.DataShapingRibbonPageGroup();
            this.snMergeFieldPropertiesRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.SNMergeFieldPropertiesRibbonPageGroup();
            this.groupToolsRibbonPage1 = new DevExpress.Snap.Extensions.UI.GroupToolsRibbonPage();
            this.groupingRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.GroupingRibbonPageGroup();
            this.listToolsRibbonPage1 = new DevExpress.Snap.Extensions.UI.ListToolsRibbonPage();
            this.listHeaderAndFooterRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.ListHeaderAndFooterRibbonPageGroup();
            this.listCommandsRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.ListCommandsRibbonPageGroup();
            this.listEditorRowLimitRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.ListEditorRowLimitRibbonPageGroup();
            this.chartRibbonPageCategory1 = new DevExpress.XtraCharts.UI.ChartRibbonPageCategory();
            this.createChartRibbonPage1 = new DevExpress.XtraCharts.UI.CreateChartRibbonPage();
            this.chartTypeRibbonPageGroup1 = new DevExpress.XtraCharts.UI.ChartTypeRibbonPageGroup();
            this.chartAppearanceRibbonPageGroup1 = new DevExpress.XtraCharts.UI.ChartAppearanceRibbonPageGroup();
            this.chartWizardRibbonPageGroup1 = new DevExpress.XtraCharts.UI.ChartWizardRibbonPageGroup();
            this.fileRibbonPage1 = new DevExpress.XtraRichEdit.UI.FileRibbonPage();
            this.commonRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup();
            this.dataRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.DataRibbonPageGroup();
            this.homeRibbonPage1 = new DevExpress.XtraRichEdit.UI.HomeRibbonPage();
            this.clipboardRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup();
            this.fontRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.FontRibbonPageGroup();
            this.paragraphRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup();
            this.editingRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup();
            this.insertRibbonPage1 = new DevExpress.XtraRichEdit.UI.InsertRibbonPage();
            this.pagesRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup();
            this.tablesRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup();
            this.illustrationsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup();
            this.toolboxRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.ToolboxRibbonPageGroup();
            this.linksRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup();
            this.headerFooterRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup();
            this.textRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TextRibbonPageGroup();
            this.symbolsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup();
            this.pageLayoutRibbonPage1 = new DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage();
            this.pageSetupRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup();
            this.pageBackgroundRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.PageBackgroundRibbonPageGroup();
            this.viewRibbonPage1 = new DevExpress.XtraRichEdit.UI.ViewRibbonPage();
            this.documentViewsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup();
            this.showRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup();
            this.zoomRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup();
            this.viewRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.ViewRibbonPageGroup();
            this.mailMergeRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup();
            this.reviewRibbonPage1 = new DevExpress.XtraRichEdit.UI.ReviewRibbonPage();
            this.documentProofingRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup();
            this.referencesRibbonPage1 = new DevExpress.XtraRichEdit.UI.ReferencesRibbonPage();
            this.tableOfContentsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableOfContentsRibbonPageGroup();
            this.captionsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.CaptionsRibbonPageGroup();
            this.snapDockManager1 = new DevExpress.Snap.Extensions.SnapDockManager(this.components);
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.fieldListDockPanel1 = new DevExpress.Snap.Extensions.UI.FieldListDockPanel();
            this.fieldListDockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.reportExplorerDockPanel1 = new DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel();
            this.reportExplorerDockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.snapDocumentManager1 = new DevExpress.Snap.Extensions.SnapDocumentManager(this.components);
            this.noDocumentsView1 = new DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(this.components);
            this.snapBarController1 = new DevExpress.Snap.Extensions.SnapBarController();
            this.insertPageBreakItem2 = new DevExpress.XtraRichEdit.UI.InsertPageBreakItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBorderLineStyle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBorderLineWeight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFloatingObjectOutlineWeight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemEditorRowLimitEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapDockManager1)).BeginInit();
            this.panelContainer1.SuspendLayout();
            this.fieldListDockPanel1.SuspendLayout();
            this.reportExplorerDockPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snapDocumentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // stylesRibbonPageGroup1
            // 
            this.stylesRibbonPageGroup1.ItemLinks.Add(this.galleryChangeStyleItem1);
            this.stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1";
            // 
            // galleryChangeStyleItem1
            // 
            // 
            // 
            // 
            this.galleryChangeStyleItem1.Gallery.ColumnCount = 10;
            this.galleryChangeStyleItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.galleryChangeStyleItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.galleryChangeStyleItem1.Id = 63;
            this.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1";
            // 
            // snapControl1
            // 
            this.snapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snapControl1.EnableToolTips = true;
            this.snapControl1.Location = new System.Drawing.Point(0, 142);
            this.snapControl1.MenuManager = this.ribbonControl1;
            this.snapControl1.Name = "snapControl1";
            this.snapControl1.Options.Fields.EnableEmptyFieldDataAlias = true;
            this.snapControl1.Options.SnapMailMergeVisualOptions.DataSourceName = null;
            this.snapControl1.Size = new System.Drawing.Size(885, 405);
            this.snapControl1.TabIndex = 0;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.fileNewItem1,
            this.fileOpenItem1,
            this.fileSaveItem1,
            this.fileSaveAsItem1,
            this.commandBarItem1,
            this.quickPrintItem1,
            this.printItem1,
            this.printPreviewItem1,
            this.undoItem1,
            this.redoItem1,
            this.commandBarItem2,
            this.pasteItem1,
            this.cutItem1,
            this.copyItem1,
            this.pasteSpecialItem1,
            this.barButtonGroup1,
            this.changeFontNameItem1,
            this.changeFontSizeItem1,
            this.fontSizeIncreaseItem1,
            this.fontSizeDecreaseItem1,
            this.barButtonGroup2,
            this.toggleFontBoldItem1,
            this.toggleFontItalicItem1,
            this.toggleFontUnderlineItem1,
            this.toggleFontDoubleUnderlineItem1,
            this.toggleFontStrikeoutItem1,
            this.toggleFontDoubleStrikeoutItem1,
            this.toggleFontSuperscriptItem1,
            this.toggleFontSubscriptItem1,
            this.barButtonGroup3,
            this.changeFontColorItem1,
            this.changeFontBackColorItem1,
            this.changeTextCaseItem1,
            this.makeTextUpperCaseItem1,
            this.makeTextLowerCaseItem1,
            this.toggleTextCaseItem1,
            this.clearFormattingItem1,
            this.barButtonGroup4,
            this.toggleBulletedListItem1,
            this.toggleNumberingListItem1,
            this.toggleMultiLevelListItem1,
            this.barButtonGroup5,
            this.decreaseIndentItem1,
            this.increaseIndentItem1,
            this.barButtonGroup6,
            this.toggleParagraphAlignmentLeftItem1,
            this.toggleParagraphAlignmentCenterItem1,
            this.toggleParagraphAlignmentRightItem1,
            this.toggleParagraphAlignmentJustifyItem1,
            this.toggleShowWhitespaceItem1,
            this.barButtonGroup7,
            this.changeParagraphLineSpacingItem1,
            this.setSingleParagraphSpacingItem1,
            this.setSesquialteralParagraphSpacingItem1,
            this.setDoubleParagraphSpacingItem1,
            this.showLineSpacingFormItem1,
            this.addSpacingBeforeParagraphItem1,
            this.removeSpacingBeforeParagraphItem1,
            this.addSpacingAfterParagraphItem1,
            this.removeSpacingAfterParagraphItem1,
            this.changeParagraphBackColorItem1,
            this.galleryChangeStyleItem1,
            this.findItem1,
            this.replaceItem1,
            this.insertPageBreakItem1,
            this.insertTableItem1,
            this.insertPictureItem1,
            this.insertFloatingPictureItem1,
            this.commandBarItem3,
            this.commandBarItem4,
            this.commandBarItem5,
            this.insertBookmarkItem1,
            this.insertHyperlinkItem1,
            this.editPageHeaderItem1,
            this.editPageFooterItem1,
            this.insertPageNumberItem1,
            this.insertPageCountItem1,
            this.insertTextBoxItem1,
            this.insertSymbolItem1,
            this.changeSectionPageMarginsItem1,
            this.setNormalSectionPageMarginsItem1,
            this.setNarrowSectionPageMarginsItem1,
            this.setModerateSectionPageMarginsItem1,
            this.setWideSectionPageMarginsItem1,
            this.showPageMarginsSetupFormItem1,
            this.changeSectionPageOrientationItem1,
            this.setPortraitPageOrientationItem1,
            this.setLandscapePageOrientationItem1,
            this.changeSectionPaperKindItem1,
            this.changeSectionColumnsItem1,
            this.setSectionOneColumnItem1,
            this.setSectionTwoColumnsItem1,
            this.setSectionThreeColumnsItem1,
            this.showColumnsSetupFormItem1,
            this.insertBreakItem1,
            this.insertColumnBreakItem1,
            this.insertSectionBreakNextPageItem1,
            this.insertSectionBreakEvenPageItem1,
            this.insertSectionBreakOddPageItem1,
            this.changeSectionLineNumberingItem1,
            this.setSectionLineNumberingNoneItem1,
            this.setSectionLineNumberingContinuousItem1,
            this.setSectionLineNumberingRestartNewPageItem1,
            this.setSectionLineNumberingRestartNewSectionItem1,
            this.toggleParagraphSuppressLineNumbersItem1,
            this.showLineNumberingFormItem1,
            this.changePageColorItem1,
            this.switchToSimpleViewItem1,
            this.switchToDraftViewItem1,
            this.switchToPrintLayoutViewItem1,
            this.toggleShowHorizontalRulerItem1,
            this.toggleShowVerticalRulerItem1,
            this.zoomOutItem1,
            this.zoomInItem1,
            this.snapBarToolbarsListItem1,
            this.commandBarCheckItem1,
            this.showAllFieldCodesItem1,
            this.showAllFieldResultsItem1,
            this.toggleFieldHighlightingItem1,
            this.goToPageHeaderItem1,
            this.goToPageFooterItem1,
            this.goToNextHeaderFooterItem1,
            this.goToPreviousHeaderFooterItem1,
            this.toggleLinkToPreviousItem1,
            this.toggleDifferentFirstPageItem1,
            this.toggleDifferentOddAndEvenPagesItem1,
            this.closePageHeaderFooterItem1,
            this.toggleFirstRowItem1,
            this.toggleLastRowItem1,
            this.toggleBandedRowsItem1,
            this.toggleFirstColumnItem1,
            this.toggleLastColumnItem1,
            this.toggleBandedColumnsItem1,
            this.galleryChangeTableStyleItem1,
            this.galleryChangeTableCellStyleItem1,
            this.changeTableBorderLineStyleItem1,
            this.changeTableBorderLineWeightItem1,
            this.changeTableBorderColorItem1,
            this.changeTableBordersItem1,
            this.toggleTableCellsBottomBorderItem1,
            this.toggleTableCellsTopBorderItem1,
            this.toggleTableCellsLeftBorderItem1,
            this.toggleTableCellsRightBorderItem1,
            this.resetTableCellsAllBordersItem1,
            this.toggleTableCellsAllBordersItem1,
            this.toggleTableCellsOutsideBorderItem1,
            this.toggleTableCellsInsideBorderItem1,
            this.toggleTableCellsInsideHorizontalBorderItem1,
            this.toggleTableCellsInsideVerticalBorderItem1,
            this.toggleShowTableGridLinesItem1,
            this.changeTableCellsShadingItem1,
            this.selectTableElementsItem1,
            this.selectTableCellItem1,
            this.selectTableColumnItem1,
            this.selectTableRowItem1,
            this.selectTableItem1,
            this.showTablePropertiesFormItem1,
            this.deleteTableElementsItem1,
            this.showDeleteTableCellsFormItem1,
            this.deleteTableColumnsItem1,
            this.deleteTableRowsItem1,
            this.deleteTableItem1,
            this.insertTableRowAboveItem1,
            this.insertTableRowBelowItem1,
            this.insertTableColumnToLeftItem1,
            this.insertTableColumnToRightItem1,
            this.mergeTableCellsItem1,
            this.showSplitTableCellsForm1,
            this.splitTableItem1,
            this.toggleTableAutoFitItem1,
            this.toggleTableAutoFitContentsItem1,
            this.toggleTableAutoFitWindowItem1,
            this.toggleTableFixedColumnWidthItem1,
            this.toggleTableCellsTopLeftAlignmentItem1,
            this.toggleTableCellsMiddleLeftAlignmentItem1,
            this.toggleTableCellsBottomLeftAlignmentItem1,
            this.toggleTableCellsTopCenterAlignmentItem1,
            this.toggleTableCellsMiddleCenterAlignmentItem1,
            this.toggleTableCellsBottomCenterAlignmentItem1,
            this.toggleTableCellsTopRightAlignmentItem1,
            this.toggleTableCellsMiddleRightAlignmentItem1,
            this.toggleTableCellsBottomRightAlignmentItem1,
            this.showTableOptionsFormItem1,
            this.checkSpellingItem1,
            this.insertTableOfContentsItem1,
            this.updateTableOfContentsItem1,
            this.addParagraphsToTableOfContentItem1,
            this.setParagraphHeadingLevelItem1,
            this.setParagraphHeadingLevelItem2,
            this.setParagraphHeadingLevelItem3,
            this.setParagraphHeadingLevelItem4,
            this.setParagraphHeadingLevelItem5,
            this.setParagraphHeadingLevelItem6,
            this.setParagraphHeadingLevelItem7,
            this.setParagraphHeadingLevelItem8,
            this.setParagraphHeadingLevelItem9,
            this.setParagraphHeadingLevelItem10,
            this.insertCaptionPlaceholderItem1,
            this.insertFiguresCaptionItems1,
            this.insertTablesCaptionItems1,
            this.insertEquationsCaptionItems1,
            this.insertTableOfFiguresPlaceholderItem1,
            this.insertTableOfFiguresItems1,
            this.insertTableOfTablesItems1,
            this.insertTableOfEquationsItems1,
            this.updateTableOfFiguresItem1,
            this.changeFloatingObjectFillColorItem1,
            this.changeFloatingObjectOutlineColorItem1,
            this.changeFloatingObjectOutlineWeightItem1,
            this.changeFloatingObjectTextWrapTypeItem1,
            this.setFloatingObjectSquareTextWrapTypeItem1,
            this.setFloatingObjectTightTextWrapTypeItem1,
            this.setFloatingObjectThroughTextWrapTypeItem1,
            this.setFloatingObjectTopAndBottomTextWrapTypeItem1,
            this.setFloatingObjectBehindTextWrapTypeItem1,
            this.setFloatingObjectInFrontOfTextWrapTypeItem1,
            this.changeFloatingObjectAlignmentItem1,
            this.setFloatingObjectTopLeftAlignmentItem1,
            this.setFloatingObjectTopCenterAlignmentItem1,
            this.setFloatingObjectTopRightAlignmentItem1,
            this.setFloatingObjectMiddleLeftAlignmentItem1,
            this.setFloatingObjectMiddleCenterAlignmentItem1,
            this.setFloatingObjectMiddleRightAlignmentItem1,
            this.setFloatingObjectBottomLeftAlignmentItem1,
            this.setFloatingObjectBottomCenterAlignmentItem1,
            this.setFloatingObjectBottomRightAlignmentItem1,
            this.floatingObjectBringForwardSubItem1,
            this.floatingObjectBringForwardItem1,
            this.floatingObjectBringToFrontItem1,
            this.floatingObjectBringInFrontOfTextItem1,
            this.floatingObjectSendBackwardSubItem1,
            this.floatingObjectSendBackwardItem1,
            this.floatingObjectSendToBackItem1,
            this.floatingObjectSendBehindTextItem1,
            this.themesGalleryBarItem1,
            this.commandBarCheckItem2,
            this.commandBarCheckItem3,
            this.commandBarCheckItem4,
            this.commandBarSubItem1,
            this.commandBarCheckItem5,
            this.commandBarCheckItem6,
            this.commandBarCheckItem7,
            this.commandBarCheckItem8,
            this.commandBarCheckItem9,
            this.filterPopupButtonItem1,
            this.propertiesBarButtonItem1,
            this.commandBarSubItem2,
            this.commandBarCheckItem10,
            this.commandBarCheckItem11,
            this.commandBarSubItem3,
            this.commandBarCheckItem12,
            this.commandBarCheckItem13,
            this.commandBarItem6,
            this.commandBarItem7,
            this.commandBarSubItem4,
            this.commandBarCheckItem14,
            this.commandBarCheckItem15,
            this.commandBarCheckItem16,
            this.commandBarCheckItem17,
            this.commandBarCheckItem18,
            this.commandBarCheckItem19,
            this.commandBarCheckItem20,
            this.commandBarSubItem5,
            this.commandBarCheckItem21,
            this.commandBarCheckItem22,
            this.commandBarSubItem6,
            this.commandBarCheckItem23,
            this.commandBarCheckItem24,
            this.commandBarItem8,
            this.commandBarItem9,
            this.commandBarSubItem7,
            this.commandBarCheckItem25,
            this.commandBarCheckItem26,
            this.commandBarCheckItem27,
            this.commandBarCheckItem28,
            this.commandBarCheckItem29,
            this.commandBarCheckItem30,
            this.commandBarCheckItem31,
            this.commandBarItem10,
            this.barButtonGroup8,
            this.changeEditorRowLimitItem1,
            this.createBarBaseItem1,
            this.createLineBaseItem1,
            this.createPieBaseItem1,
            this.createRotatedBarBaseItem1,
            this.createAreaBaseItem1,
            this.createOtherSeriesTypesBaseItem1,
            this.changePaletteGalleryBaseItem1,
            this.changeAppearanceGalleryBaseItem1,
            this.runWizardChartItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 291;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.headerFooterToolsRibbonPageCategory1,
            this.tableToolsRibbonPageCategory1,
            this.floatingPictureToolsRibbonPageCategory1,
            this.dataToolsRibbonPageCategory1,
            this.chartRibbonPageCategory1});
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.fileRibbonPage1,
            this.homeRibbonPage1,
            this.insertRibbonPage1,
            this.pageLayoutRibbonPage1,
            this.viewRibbonPage1,
            this.reviewRibbonPage1,
            this.referencesRibbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemFontEdit1,
            this.repositoryItemRichEditFontSizeEdit1,
            this.repositoryItemBorderLineStyle1,
            this.repositoryItemBorderLineWeight1,
            this.repositoryItemFloatingObjectOutlineWeight1,
            this.repositoryItemEditorRowLimitEdit1});
            this.ribbonControl1.Size = new System.Drawing.Size(1085, 142);
            // 
            // fileNewItem1
            // 
            this.fileNewItem1.Id = 9;
            this.fileNewItem1.Name = "fileNewItem1";
            // 
            // fileOpenItem1
            // 
            this.fileOpenItem1.Id = 10;
            this.fileOpenItem1.Name = "fileOpenItem1";
            // 
            // fileSaveItem1
            // 
            this.fileSaveItem1.Id = 11;
            this.fileSaveItem1.Name = "fileSaveItem1";
            // 
            // fileSaveAsItem1
            // 
            this.fileSaveAsItem1.Id = 12;
            this.fileSaveAsItem1.Name = "fileSaveAsItem1";
            // 
            // commandBarItem1
            // 
            this.commandBarItem1.Id = 13;
            this.commandBarItem1.Name = "commandBarItem1";
            this.commandBarItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ExportDocument;
            // 
            // quickPrintItem1
            // 
            this.quickPrintItem1.Id = 14;
            this.quickPrintItem1.Name = "quickPrintItem1";
            // 
            // printItem1
            // 
            this.printItem1.Id = 15;
            this.printItem1.Name = "printItem1";
            // 
            // printPreviewItem1
            // 
            this.printPreviewItem1.Id = 16;
            this.printPreviewItem1.Name = "printPreviewItem1";
            // 
            // undoItem1
            // 
            this.undoItem1.Id = 17;
            this.undoItem1.Name = "undoItem1";
            // 
            // redoItem1
            // 
            this.redoItem1.Id = 18;
            this.redoItem1.Name = "redoItem1";
            // 
            // commandBarItem2
            // 
            this.commandBarItem2.Id = 19;
            this.commandBarItem2.Name = "commandBarItem2";
            this.commandBarItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.NewDataSource;
            // 
            // pasteItem1
            // 
            this.pasteItem1.Id = 20;
            this.pasteItem1.Name = "pasteItem1";
            // 
            // cutItem1
            // 
            this.cutItem1.Id = 21;
            this.cutItem1.Name = "cutItem1";
            // 
            // copyItem1
            // 
            this.copyItem1.Id = 22;
            this.copyItem1.Name = "copyItem1";
            // 
            // pasteSpecialItem1
            // 
            this.pasteSpecialItem1.Id = 23;
            this.pasteSpecialItem1.Name = "pasteSpecialItem1";
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Id = 1;
            this.barButtonGroup1.ItemLinks.Add(this.changeFontNameItem1);
            this.barButtonGroup1.ItemLinks.Add(this.changeFontSizeItem1);
            this.barButtonGroup1.ItemLinks.Add(this.fontSizeIncreaseItem1);
            this.barButtonGroup1.ItemLinks.Add(this.fontSizeDecreaseItem1);
            this.barButtonGroup1.Name = "barButtonGroup1";
            this.barButtonGroup1.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}";
            // 
            // changeFontNameItem1
            // 
            this.changeFontNameItem1.Edit = this.repositoryItemFontEdit1;
            this.changeFontNameItem1.Id = 24;
            this.changeFontNameItem1.Name = "changeFontNameItem1";
            // 
            // repositoryItemFontEdit1
            // 
            this.repositoryItemFontEdit1.AutoHeight = false;
            this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            // 
            // changeFontSizeItem1
            // 
            this.changeFontSizeItem1.Edit = this.repositoryItemRichEditFontSizeEdit1;
            this.changeFontSizeItem1.Id = 25;
            this.changeFontSizeItem1.Name = "changeFontSizeItem1";
            // 
            // repositoryItemRichEditFontSizeEdit1
            // 
            this.repositoryItemRichEditFontSizeEdit1.AutoHeight = false;
            this.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemRichEditFontSizeEdit1.Control = this.snapControl1;
            this.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1";
            // 
            // fontSizeIncreaseItem1
            // 
            this.fontSizeIncreaseItem1.Id = 26;
            this.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1";
            // 
            // fontSizeDecreaseItem1
            // 
            this.fontSizeDecreaseItem1.Id = 27;
            this.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1";
            // 
            // barButtonGroup2
            // 
            this.barButtonGroup2.Id = 2;
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontBoldItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontItalicItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontUnderlineItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontDoubleUnderlineItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontStrikeoutItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontDoubleStrikeoutItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontSuperscriptItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontSubscriptItem1);
            this.barButtonGroup2.Name = "barButtonGroup2";
            this.barButtonGroup2.Tag = "{433DA7F0-03E2-4650-9DB5-66DD92D16E39}";
            // 
            // toggleFontBoldItem1
            // 
            this.toggleFontBoldItem1.Id = 28;
            this.toggleFontBoldItem1.Name = "toggleFontBoldItem1";
            // 
            // toggleFontItalicItem1
            // 
            this.toggleFontItalicItem1.Id = 29;
            this.toggleFontItalicItem1.Name = "toggleFontItalicItem1";
            // 
            // toggleFontUnderlineItem1
            // 
            this.toggleFontUnderlineItem1.Id = 30;
            this.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1";
            // 
            // toggleFontDoubleUnderlineItem1
            // 
            this.toggleFontDoubleUnderlineItem1.Id = 31;
            this.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1";
            // 
            // toggleFontStrikeoutItem1
            // 
            this.toggleFontStrikeoutItem1.Id = 32;
            this.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1";
            // 
            // toggleFontDoubleStrikeoutItem1
            // 
            this.toggleFontDoubleStrikeoutItem1.Id = 33;
            this.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1";
            // 
            // toggleFontSuperscriptItem1
            // 
            this.toggleFontSuperscriptItem1.Id = 34;
            this.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1";
            // 
            // toggleFontSubscriptItem1
            // 
            this.toggleFontSubscriptItem1.Id = 35;
            this.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1";
            // 
            // barButtonGroup3
            // 
            this.barButtonGroup3.Id = 3;
            this.barButtonGroup3.ItemLinks.Add(this.changeFontColorItem1);
            this.barButtonGroup3.ItemLinks.Add(this.changeFontBackColorItem1);
            this.barButtonGroup3.Name = "barButtonGroup3";
            this.barButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}";
            // 
            // changeFontColorItem1
            // 
            this.changeFontColorItem1.Id = 36;
            this.changeFontColorItem1.Name = "changeFontColorItem1";
            // 
            // changeFontBackColorItem1
            // 
            this.changeFontBackColorItem1.Id = 37;
            this.changeFontBackColorItem1.Name = "changeFontBackColorItem1";
            // 
            // changeTextCaseItem1
            // 
            this.changeTextCaseItem1.Id = 38;
            this.changeTextCaseItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.makeTextUpperCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.makeTextLowerCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTextCaseItem1)});
            this.changeTextCaseItem1.Name = "changeTextCaseItem1";
            // 
            // makeTextUpperCaseItem1
            // 
            this.makeTextUpperCaseItem1.Id = 39;
            this.makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1";
            // 
            // makeTextLowerCaseItem1
            // 
            this.makeTextLowerCaseItem1.Id = 40;
            this.makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1";
            // 
            // toggleTextCaseItem1
            // 
            this.toggleTextCaseItem1.Id = 41;
            this.toggleTextCaseItem1.Name = "toggleTextCaseItem1";
            // 
            // clearFormattingItem1
            // 
            this.clearFormattingItem1.Id = 42;
            this.clearFormattingItem1.Name = "clearFormattingItem1";
            // 
            // barButtonGroup4
            // 
            this.barButtonGroup4.Id = 4;
            this.barButtonGroup4.ItemLinks.Add(this.toggleBulletedListItem1);
            this.barButtonGroup4.ItemLinks.Add(this.toggleNumberingListItem1);
            this.barButtonGroup4.ItemLinks.Add(this.toggleMultiLevelListItem1);
            this.barButtonGroup4.Name = "barButtonGroup4";
            this.barButtonGroup4.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}";
            // 
            // toggleBulletedListItem1
            // 
            this.toggleBulletedListItem1.Id = 43;
            this.toggleBulletedListItem1.Name = "toggleBulletedListItem1";
            // 
            // toggleNumberingListItem1
            // 
            this.toggleNumberingListItem1.Id = 44;
            this.toggleNumberingListItem1.Name = "toggleNumberingListItem1";
            // 
            // toggleMultiLevelListItem1
            // 
            this.toggleMultiLevelListItem1.Id = 45;
            this.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1";
            // 
            // barButtonGroup5
            // 
            this.barButtonGroup5.Id = 5;
            this.barButtonGroup5.ItemLinks.Add(this.decreaseIndentItem1);
            this.barButtonGroup5.ItemLinks.Add(this.increaseIndentItem1);
            this.barButtonGroup5.ItemLinks.Add(this.toggleShowWhitespaceItem1);
            this.barButtonGroup5.Name = "barButtonGroup5";
            this.barButtonGroup5.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}";
            // 
            // decreaseIndentItem1
            // 
            this.decreaseIndentItem1.Id = 46;
            this.decreaseIndentItem1.Name = "decreaseIndentItem1";
            // 
            // increaseIndentItem1
            // 
            this.increaseIndentItem1.Id = 47;
            this.increaseIndentItem1.Name = "increaseIndentItem1";
            // 
            // toggleShowWhitespaceItem1
            // 
            this.toggleShowWhitespaceItem1.Id = 48;
            this.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1";
            // 
            // barButtonGroup6
            // 
            this.barButtonGroup6.Id = 6;
            this.barButtonGroup6.ItemLinks.Add(this.toggleParagraphAlignmentLeftItem1);
            this.barButtonGroup6.ItemLinks.Add(this.toggleParagraphAlignmentCenterItem1);
            this.barButtonGroup6.ItemLinks.Add(this.toggleParagraphAlignmentRightItem1);
            this.barButtonGroup6.ItemLinks.Add(this.toggleParagraphAlignmentJustifyItem1);
            this.barButtonGroup6.Name = "barButtonGroup6";
            this.barButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}";
            // 
            // toggleParagraphAlignmentLeftItem1
            // 
            this.toggleParagraphAlignmentLeftItem1.Id = 49;
            this.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1";
            // 
            // toggleParagraphAlignmentCenterItem1
            // 
            this.toggleParagraphAlignmentCenterItem1.Id = 50;
            this.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1";
            // 
            // toggleParagraphAlignmentRightItem1
            // 
            this.toggleParagraphAlignmentRightItem1.Id = 51;
            this.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1";
            // 
            // toggleParagraphAlignmentJustifyItem1
            // 
            this.toggleParagraphAlignmentJustifyItem1.Id = 52;
            this.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1";
            // 
            // barButtonGroup7
            // 
            this.barButtonGroup7.Id = 7;
            this.barButtonGroup7.ItemLinks.Add(this.changeParagraphLineSpacingItem1);
            this.barButtonGroup7.ItemLinks.Add(this.changeParagraphBackColorItem1);
            this.barButtonGroup7.Name = "barButtonGroup7";
            this.barButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}";
            // 
            // changeParagraphLineSpacingItem1
            // 
            this.changeParagraphLineSpacingItem1.Id = 53;
            this.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setSingleParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSesquialteralParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setDoubleParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.showLineSpacingFormItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.addSpacingBeforeParagraphItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.removeSpacingBeforeParagraphItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.addSpacingAfterParagraphItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.removeSpacingAfterParagraphItem1)});
            this.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1";
            // 
            // setSingleParagraphSpacingItem1
            // 
            this.setSingleParagraphSpacingItem1.Id = 54;
            this.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1";
            // 
            // setSesquialteralParagraphSpacingItem1
            // 
            this.setSesquialteralParagraphSpacingItem1.Id = 55;
            this.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1";
            // 
            // setDoubleParagraphSpacingItem1
            // 
            this.setDoubleParagraphSpacingItem1.Id = 56;
            this.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1";
            // 
            // showLineSpacingFormItem1
            // 
            this.showLineSpacingFormItem1.Id = 57;
            this.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1";
            // 
            // addSpacingBeforeParagraphItem1
            // 
            this.addSpacingBeforeParagraphItem1.Id = 58;
            this.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1";
            // 
            // removeSpacingBeforeParagraphItem1
            // 
            this.removeSpacingBeforeParagraphItem1.Id = 59;
            this.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1";
            // 
            // addSpacingAfterParagraphItem1
            // 
            this.addSpacingAfterParagraphItem1.Id = 60;
            this.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1";
            // 
            // removeSpacingAfterParagraphItem1
            // 
            this.removeSpacingAfterParagraphItem1.Id = 61;
            this.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1";
            // 
            // changeParagraphBackColorItem1
            // 
            this.changeParagraphBackColorItem1.Id = 62;
            this.changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1";
            // 
            // findItem1
            // 
            this.findItem1.Id = 64;
            this.findItem1.Name = "findItem1";
            // 
            // replaceItem1
            // 
            this.replaceItem1.Id = 65;
            this.replaceItem1.Name = "replaceItem1";
            // 
            // insertPageBreakItem1
            // 
            this.insertPageBreakItem1.Id = 66;
            this.insertPageBreakItem1.Name = "insertPageBreakItem1";
            // 
            // insertTableItem1
            // 
            this.insertTableItem1.Id = 67;
            this.insertTableItem1.Name = "insertTableItem1";
            // 
            // insertPictureItem1
            // 
            this.insertPictureItem1.Id = 68;
            this.insertPictureItem1.Name = "insertPictureItem1";
            // 
            // insertFloatingPictureItem1
            // 
            this.insertFloatingPictureItem1.Id = 69;
            this.insertFloatingPictureItem1.Name = "insertFloatingPictureItem1";
            // 
            // commandBarItem3
            // 
            this.commandBarItem3.Id = 70;
            this.commandBarItem3.Name = "commandBarItem3";
            this.commandBarItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertBarCode;
            // 
            // commandBarItem4
            // 
            this.commandBarItem4.Id = 71;
            this.commandBarItem4.Name = "commandBarItem4";
            this.commandBarItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertCheckBox;
            // 
            // commandBarItem5
            // 
            this.commandBarItem5.Id = 72;
            this.commandBarItem5.Name = "commandBarItem5";
            this.commandBarItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertChart;
            // 
            // insertBookmarkItem1
            // 
            this.insertBookmarkItem1.Id = 73;
            this.insertBookmarkItem1.Name = "insertBookmarkItem1";
            // 
            // insertHyperlinkItem1
            // 
            this.insertHyperlinkItem1.Id = 74;
            this.insertHyperlinkItem1.Name = "insertHyperlinkItem1";
            // 
            // editPageHeaderItem1
            // 
            this.editPageHeaderItem1.Id = 75;
            this.editPageHeaderItem1.Name = "editPageHeaderItem1";
            // 
            // editPageFooterItem1
            // 
            this.editPageFooterItem1.Id = 76;
            this.editPageFooterItem1.Name = "editPageFooterItem1";
            // 
            // insertPageNumberItem1
            // 
            this.insertPageNumberItem1.Id = 77;
            this.insertPageNumberItem1.Name = "insertPageNumberItem1";
            // 
            // insertPageCountItem1
            // 
            this.insertPageCountItem1.Id = 78;
            this.insertPageCountItem1.Name = "insertPageCountItem1";
            // 
            // insertTextBoxItem1
            // 
            this.insertTextBoxItem1.Id = 79;
            this.insertTextBoxItem1.Name = "insertTextBoxItem1";
            // 
            // insertSymbolItem1
            // 
            this.insertSymbolItem1.Id = 80;
            this.insertSymbolItem1.Name = "insertSymbolItem1";
            // 
            // changeSectionPageMarginsItem1
            // 
            this.changeSectionPageMarginsItem1.Id = 81;
            this.changeSectionPageMarginsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setNormalSectionPageMarginsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setNarrowSectionPageMarginsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setModerateSectionPageMarginsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setWideSectionPageMarginsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.showPageMarginsSetupFormItem1)});
            this.changeSectionPageMarginsItem1.Name = "changeSectionPageMarginsItem1";
            // 
            // setNormalSectionPageMarginsItem1
            // 
            this.setNormalSectionPageMarginsItem1.Id = 82;
            this.setNormalSectionPageMarginsItem1.Name = "setNormalSectionPageMarginsItem1";
            // 
            // setNarrowSectionPageMarginsItem1
            // 
            this.setNarrowSectionPageMarginsItem1.Id = 83;
            this.setNarrowSectionPageMarginsItem1.Name = "setNarrowSectionPageMarginsItem1";
            // 
            // setModerateSectionPageMarginsItem1
            // 
            this.setModerateSectionPageMarginsItem1.Id = 84;
            this.setModerateSectionPageMarginsItem1.Name = "setModerateSectionPageMarginsItem1";
            // 
            // setWideSectionPageMarginsItem1
            // 
            this.setWideSectionPageMarginsItem1.Id = 85;
            this.setWideSectionPageMarginsItem1.Name = "setWideSectionPageMarginsItem1";
            // 
            // showPageMarginsSetupFormItem1
            // 
            this.showPageMarginsSetupFormItem1.Id = 86;
            this.showPageMarginsSetupFormItem1.Name = "showPageMarginsSetupFormItem1";
            // 
            // changeSectionPageOrientationItem1
            // 
            this.changeSectionPageOrientationItem1.Id = 87;
            this.changeSectionPageOrientationItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setPortraitPageOrientationItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setLandscapePageOrientationItem1)});
            this.changeSectionPageOrientationItem1.Name = "changeSectionPageOrientationItem1";
            // 
            // setPortraitPageOrientationItem1
            // 
            this.setPortraitPageOrientationItem1.Id = 88;
            this.setPortraitPageOrientationItem1.Name = "setPortraitPageOrientationItem1";
            // 
            // setLandscapePageOrientationItem1
            // 
            this.setLandscapePageOrientationItem1.Id = 89;
            this.setLandscapePageOrientationItem1.Name = "setLandscapePageOrientationItem1";
            // 
            // changeSectionPaperKindItem1
            // 
            this.changeSectionPaperKindItem1.Id = 90;
            this.changeSectionPaperKindItem1.Name = "changeSectionPaperKindItem1";
            // 
            // changeSectionColumnsItem1
            // 
            this.changeSectionColumnsItem1.Id = 91;
            this.changeSectionColumnsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setSectionOneColumnItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSectionTwoColumnsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSectionThreeColumnsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.showColumnsSetupFormItem1)});
            this.changeSectionColumnsItem1.Name = "changeSectionColumnsItem1";
            // 
            // setSectionOneColumnItem1
            // 
            this.setSectionOneColumnItem1.Id = 92;
            this.setSectionOneColumnItem1.Name = "setSectionOneColumnItem1";
            // 
            // setSectionTwoColumnsItem1
            // 
            this.setSectionTwoColumnsItem1.Id = 93;
            this.setSectionTwoColumnsItem1.Name = "setSectionTwoColumnsItem1";
            // 
            // setSectionThreeColumnsItem1
            // 
            this.setSectionThreeColumnsItem1.Id = 94;
            this.setSectionThreeColumnsItem1.Name = "setSectionThreeColumnsItem1";
            // 
            // showColumnsSetupFormItem1
            // 
            this.showColumnsSetupFormItem1.Id = 95;
            this.showColumnsSetupFormItem1.Name = "showColumnsSetupFormItem1";
            // 
            // insertBreakItem1
            // 
            this.insertBreakItem1.Id = 96;
            this.insertBreakItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.insertPageBreakItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertColumnBreakItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertSectionBreakNextPageItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertSectionBreakEvenPageItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertSectionBreakOddPageItem1)});
            this.insertBreakItem1.Name = "insertBreakItem1";
            // 
            // insertColumnBreakItem1
            // 
            this.insertColumnBreakItem1.Id = 97;
            this.insertColumnBreakItem1.Name = "insertColumnBreakItem1";
            // 
            // insertSectionBreakNextPageItem1
            // 
            this.insertSectionBreakNextPageItem1.Id = 98;
            this.insertSectionBreakNextPageItem1.Name = "insertSectionBreakNextPageItem1";
            // 
            // insertSectionBreakEvenPageItem1
            // 
            this.insertSectionBreakEvenPageItem1.Id = 99;
            this.insertSectionBreakEvenPageItem1.Name = "insertSectionBreakEvenPageItem1";
            // 
            // insertSectionBreakOddPageItem1
            // 
            this.insertSectionBreakOddPageItem1.Id = 100;
            this.insertSectionBreakOddPageItem1.Name = "insertSectionBreakOddPageItem1";
            // 
            // changeSectionLineNumberingItem1
            // 
            this.changeSectionLineNumberingItem1.Id = 101;
            this.changeSectionLineNumberingItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setSectionLineNumberingNoneItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSectionLineNumberingContinuousItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSectionLineNumberingRestartNewPageItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSectionLineNumberingRestartNewSectionItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleParagraphSuppressLineNumbersItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.showLineNumberingFormItem1)});
            this.changeSectionLineNumberingItem1.Name = "changeSectionLineNumberingItem1";
            // 
            // setSectionLineNumberingNoneItem1
            // 
            this.setSectionLineNumberingNoneItem1.Id = 102;
            this.setSectionLineNumberingNoneItem1.Name = "setSectionLineNumberingNoneItem1";
            // 
            // setSectionLineNumberingContinuousItem1
            // 
            this.setSectionLineNumberingContinuousItem1.Id = 103;
            this.setSectionLineNumberingContinuousItem1.Name = "setSectionLineNumberingContinuousItem1";
            // 
            // setSectionLineNumberingRestartNewPageItem1
            // 
            this.setSectionLineNumberingRestartNewPageItem1.Id = 104;
            this.setSectionLineNumberingRestartNewPageItem1.Name = "setSectionLineNumberingRestartNewPageItem1";
            // 
            // setSectionLineNumberingRestartNewSectionItem1
            // 
            this.setSectionLineNumberingRestartNewSectionItem1.Id = 105;
            this.setSectionLineNumberingRestartNewSectionItem1.Name = "setSectionLineNumberingRestartNewSectionItem1";
            // 
            // toggleParagraphSuppressLineNumbersItem1
            // 
            this.toggleParagraphSuppressLineNumbersItem1.Id = 106;
            this.toggleParagraphSuppressLineNumbersItem1.Name = "toggleParagraphSuppressLineNumbersItem1";
            // 
            // showLineNumberingFormItem1
            // 
            this.showLineNumberingFormItem1.Id = 107;
            this.showLineNumberingFormItem1.Name = "showLineNumberingFormItem1";
            // 
            // changePageColorItem1
            // 
            this.changePageColorItem1.Id = 108;
            this.changePageColorItem1.Name = "changePageColorItem1";
            // 
            // switchToSimpleViewItem1
            // 
            this.switchToSimpleViewItem1.Id = 109;
            this.switchToSimpleViewItem1.Name = "switchToSimpleViewItem1";
            // 
            // switchToDraftViewItem1
            // 
            this.switchToDraftViewItem1.Id = 110;
            this.switchToDraftViewItem1.Name = "switchToDraftViewItem1";
            // 
            // switchToPrintLayoutViewItem1
            // 
            this.switchToPrintLayoutViewItem1.Id = 111;
            this.switchToPrintLayoutViewItem1.Name = "switchToPrintLayoutViewItem1";
            // 
            // toggleShowHorizontalRulerItem1
            // 
            this.toggleShowHorizontalRulerItem1.Id = 112;
            this.toggleShowHorizontalRulerItem1.Name = "toggleShowHorizontalRulerItem1";
            // 
            // toggleShowVerticalRulerItem1
            // 
            this.toggleShowVerticalRulerItem1.Id = 113;
            this.toggleShowVerticalRulerItem1.Name = "toggleShowVerticalRulerItem1";
            // 
            // zoomOutItem1
            // 
            this.zoomOutItem1.Id = 114;
            this.zoomOutItem1.Name = "zoomOutItem1";
            // 
            // zoomInItem1
            // 
            this.zoomInItem1.Id = 115;
            this.zoomInItem1.Name = "zoomInItem1";
            // 
            // snapBarToolbarsListItem1
            // 
            this.snapBarToolbarsListItem1.Caption = "&Windows";
            this.snapBarToolbarsListItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("snapBarToolbarsListItem1.Glyph")));
            this.snapBarToolbarsListItem1.Hint = "Show or hide the Data Explorer and Report Explorer windows.";
            this.snapBarToolbarsListItem1.Id = 116;
            this.snapBarToolbarsListItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("snapBarToolbarsListItem1.LargeGlyph")));
            this.snapBarToolbarsListItem1.Name = "snapBarToolbarsListItem1";
            this.snapBarToolbarsListItem1.ShowCustomizationItem = false;
            this.snapBarToolbarsListItem1.ShowDockPanels = true;
            this.snapBarToolbarsListItem1.ShowToolbars = false;
            // 
            // commandBarCheckItem1
            // 
            this.commandBarCheckItem1.Id = 117;
            this.commandBarCheckItem1.Name = "commandBarCheckItem1";
            this.commandBarCheckItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.HighlightActiveElement;
            // 
            // showAllFieldCodesItem1
            // 
            this.showAllFieldCodesItem1.Id = 118;
            this.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1";
            // 
            // showAllFieldResultsItem1
            // 
            this.showAllFieldResultsItem1.Id = 119;
            this.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1";
            // 
            // toggleFieldHighlightingItem1
            // 
            this.toggleFieldHighlightingItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleFieldHighlightingItem1.Glyph")));
            this.toggleFieldHighlightingItem1.Id = 120;
            this.toggleFieldHighlightingItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleFieldHighlightingItem1.LargeGlyph")));
            this.toggleFieldHighlightingItem1.Name = "toggleFieldHighlightingItem1";
            // 
            // goToPageHeaderItem1
            // 
            this.goToPageHeaderItem1.Id = 121;
            this.goToPageHeaderItem1.Name = "goToPageHeaderItem1";
            // 
            // goToPageFooterItem1
            // 
            this.goToPageFooterItem1.Id = 122;
            this.goToPageFooterItem1.Name = "goToPageFooterItem1";
            // 
            // goToNextHeaderFooterItem1
            // 
            this.goToNextHeaderFooterItem1.Id = 123;
            this.goToNextHeaderFooterItem1.Name = "goToNextHeaderFooterItem1";
            // 
            // goToPreviousHeaderFooterItem1
            // 
            this.goToPreviousHeaderFooterItem1.Id = 124;
            this.goToPreviousHeaderFooterItem1.Name = "goToPreviousHeaderFooterItem1";
            // 
            // toggleLinkToPreviousItem1
            // 
            this.toggleLinkToPreviousItem1.Id = 125;
            this.toggleLinkToPreviousItem1.Name = "toggleLinkToPreviousItem1";
            // 
            // toggleDifferentFirstPageItem1
            // 
            this.toggleDifferentFirstPageItem1.Id = 126;
            this.toggleDifferentFirstPageItem1.Name = "toggleDifferentFirstPageItem1";
            // 
            // toggleDifferentOddAndEvenPagesItem1
            // 
            this.toggleDifferentOddAndEvenPagesItem1.Id = 127;
            this.toggleDifferentOddAndEvenPagesItem1.Name = "toggleDifferentOddAndEvenPagesItem1";
            // 
            // closePageHeaderFooterItem1
            // 
            this.closePageHeaderFooterItem1.Id = 128;
            this.closePageHeaderFooterItem1.Name = "closePageHeaderFooterItem1";
            // 
            // toggleFirstRowItem1
            // 
            this.toggleFirstRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.toggleFirstRowItem1.Id = 129;
            this.toggleFirstRowItem1.Name = "toggleFirstRowItem1";
            // 
            // toggleLastRowItem1
            // 
            this.toggleLastRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.toggleLastRowItem1.Id = 130;
            this.toggleLastRowItem1.Name = "toggleLastRowItem1";
            // 
            // toggleBandedRowsItem1
            // 
            this.toggleBandedRowsItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.toggleBandedRowsItem1.Id = 131;
            this.toggleBandedRowsItem1.Name = "toggleBandedRowsItem1";
            // 
            // toggleFirstColumnItem1
            // 
            this.toggleFirstColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.toggleFirstColumnItem1.Id = 132;
            this.toggleFirstColumnItem1.Name = "toggleFirstColumnItem1";
            // 
            // toggleLastColumnItem1
            // 
            this.toggleLastColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.toggleLastColumnItem1.Id = 133;
            this.toggleLastColumnItem1.Name = "toggleLastColumnItem1";
            // 
            // toggleBandedColumnsItem1
            // 
            this.toggleBandedColumnsItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.toggleBandedColumnsItem1.Id = 134;
            this.toggleBandedColumnsItem1.Name = "toggleBandedColumnsItem1";
            // 
            // galleryChangeTableStyleItem1
            // 
            this.galleryChangeTableStyleItem1.CurrentItem = null;
            this.galleryChangeTableStyleItem1.CurrentItemStyle = null;
            this.galleryChangeTableStyleItem1.CurrentStyle = null;
            this.galleryChangeTableStyleItem1.DeleteItemLink = null;
            // 
            // 
            // 
            this.galleryChangeTableStyleItem1.Gallery.ColumnCount = 3;
            this.galleryChangeTableStyleItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup2});
            this.galleryChangeTableStyleItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.galleryChangeTableStyleItem1.Id = 135;
            this.galleryChangeTableStyleItem1.ModifyItemLink = null;
            this.galleryChangeTableStyleItem1.Name = "galleryChangeTableStyleItem1";
            this.galleryChangeTableStyleItem1.NewItemLink = null;
            this.galleryChangeTableStyleItem1.PopupGallery = null;
            // 
            // galleryChangeTableCellStyleItem1
            // 
            this.galleryChangeTableCellStyleItem1.CurrentCellStyle = null;
            this.galleryChangeTableCellStyleItem1.CurrentItem = null;
            this.galleryChangeTableCellStyleItem1.CurrentItemCellStyle = null;
            this.galleryChangeTableCellStyleItem1.DeleteItemLink = null;
            // 
            // 
            // 
            this.galleryChangeTableCellStyleItem1.Gallery.ColumnCount = 3;
            this.galleryChangeTableCellStyleItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup3});
            this.galleryChangeTableCellStyleItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.galleryChangeTableCellStyleItem1.Id = 136;
            this.galleryChangeTableCellStyleItem1.ModifyItemLink = null;
            this.galleryChangeTableCellStyleItem1.Name = "galleryChangeTableCellStyleItem1";
            this.galleryChangeTableCellStyleItem1.NewItemLink = null;
            this.galleryChangeTableCellStyleItem1.PopupGallery = null;
            // 
            // changeTableBorderLineStyleItem1
            // 
            this.changeTableBorderLineStyleItem1.Edit = this.repositoryItemBorderLineStyle1;
            borderInfo1.Color = System.Drawing.Color.Black;
            borderInfo1.Frame = false;
            borderInfo1.Offset = 0;
            borderInfo1.Shadow = false;
            borderInfo1.Style = DevExpress.XtraRichEdit.Model.BorderLineStyle.Single;
            borderInfo1.Width = 10;
            this.changeTableBorderLineStyleItem1.EditValue = borderInfo1;
            this.changeTableBorderLineStyleItem1.Id = 137;
            this.changeTableBorderLineStyleItem1.Name = "changeTableBorderLineStyleItem1";
            // 
            // repositoryItemBorderLineStyle1
            // 
            this.repositoryItemBorderLineStyle1.AutoHeight = false;
            this.repositoryItemBorderLineStyle1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemBorderLineStyle1.Control = this.snapControl1;
            this.repositoryItemBorderLineStyle1.Name = "repositoryItemBorderLineStyle1";
            // 
            // changeTableBorderLineWeightItem1
            // 
            this.changeTableBorderLineWeightItem1.Edit = this.repositoryItemBorderLineWeight1;
            this.changeTableBorderLineWeightItem1.EditValue = 20;
            this.changeTableBorderLineWeightItem1.Id = 138;
            this.changeTableBorderLineWeightItem1.Name = "changeTableBorderLineWeightItem1";
            // 
            // repositoryItemBorderLineWeight1
            // 
            this.repositoryItemBorderLineWeight1.AutoHeight = false;
            this.repositoryItemBorderLineWeight1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemBorderLineWeight1.Control = this.snapControl1;
            this.repositoryItemBorderLineWeight1.Name = "repositoryItemBorderLineWeight1";
            // 
            // changeTableBorderColorItem1
            // 
            this.changeTableBorderColorItem1.Id = 139;
            this.changeTableBorderColorItem1.Name = "changeTableBorderColorItem1";
            // 
            // changeTableBordersItem1
            // 
            this.changeTableBordersItem1.Id = 140;
            this.changeTableBordersItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsBottomBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsTopBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsLeftBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsRightBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.resetTableCellsAllBordersItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsAllBordersItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsOutsideBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsInsideBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsInsideHorizontalBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsInsideVerticalBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleShowTableGridLinesItem1)});
            this.changeTableBordersItem1.Name = "changeTableBordersItem1";
            // 
            // toggleTableCellsBottomBorderItem1
            // 
            this.toggleTableCellsBottomBorderItem1.Id = 141;
            this.toggleTableCellsBottomBorderItem1.Name = "toggleTableCellsBottomBorderItem1";
            // 
            // toggleTableCellsTopBorderItem1
            // 
            this.toggleTableCellsTopBorderItem1.Id = 142;
            this.toggleTableCellsTopBorderItem1.Name = "toggleTableCellsTopBorderItem1";
            // 
            // toggleTableCellsLeftBorderItem1
            // 
            this.toggleTableCellsLeftBorderItem1.Id = 143;
            this.toggleTableCellsLeftBorderItem1.Name = "toggleTableCellsLeftBorderItem1";
            // 
            // toggleTableCellsRightBorderItem1
            // 
            this.toggleTableCellsRightBorderItem1.Id = 144;
            this.toggleTableCellsRightBorderItem1.Name = "toggleTableCellsRightBorderItem1";
            // 
            // resetTableCellsAllBordersItem1
            // 
            this.resetTableCellsAllBordersItem1.Id = 145;
            this.resetTableCellsAllBordersItem1.Name = "resetTableCellsAllBordersItem1";
            // 
            // toggleTableCellsAllBordersItem1
            // 
            this.toggleTableCellsAllBordersItem1.Id = 146;
            this.toggleTableCellsAllBordersItem1.Name = "toggleTableCellsAllBordersItem1";
            // 
            // toggleTableCellsOutsideBorderItem1
            // 
            this.toggleTableCellsOutsideBorderItem1.Id = 147;
            this.toggleTableCellsOutsideBorderItem1.Name = "toggleTableCellsOutsideBorderItem1";
            // 
            // toggleTableCellsInsideBorderItem1
            // 
            this.toggleTableCellsInsideBorderItem1.Id = 148;
            this.toggleTableCellsInsideBorderItem1.Name = "toggleTableCellsInsideBorderItem1";
            // 
            // toggleTableCellsInsideHorizontalBorderItem1
            // 
            this.toggleTableCellsInsideHorizontalBorderItem1.Id = 149;
            this.toggleTableCellsInsideHorizontalBorderItem1.Name = "toggleTableCellsInsideHorizontalBorderItem1";
            // 
            // toggleTableCellsInsideVerticalBorderItem1
            // 
            this.toggleTableCellsInsideVerticalBorderItem1.Id = 150;
            this.toggleTableCellsInsideVerticalBorderItem1.Name = "toggleTableCellsInsideVerticalBorderItem1";
            // 
            // toggleShowTableGridLinesItem1
            // 
            this.toggleShowTableGridLinesItem1.Id = 151;
            this.toggleShowTableGridLinesItem1.Name = "toggleShowTableGridLinesItem1";
            // 
            // changeTableCellsShadingItem1
            // 
            this.changeTableCellsShadingItem1.Id = 152;
            this.changeTableCellsShadingItem1.Name = "changeTableCellsShadingItem1";
            // 
            // selectTableElementsItem1
            // 
            this.selectTableElementsItem1.Id = 153;
            this.selectTableElementsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.selectTableCellItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.selectTableColumnItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.selectTableRowItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.selectTableItem1)});
            this.selectTableElementsItem1.Name = "selectTableElementsItem1";
            // 
            // selectTableCellItem1
            // 
            this.selectTableCellItem1.Id = 154;
            this.selectTableCellItem1.Name = "selectTableCellItem1";
            // 
            // selectTableColumnItem1
            // 
            this.selectTableColumnItem1.Id = 155;
            this.selectTableColumnItem1.Name = "selectTableColumnItem1";
            // 
            // selectTableRowItem1
            // 
            this.selectTableRowItem1.Id = 156;
            this.selectTableRowItem1.Name = "selectTableRowItem1";
            // 
            // selectTableItem1
            // 
            this.selectTableItem1.Id = 157;
            this.selectTableItem1.Name = "selectTableItem1";
            // 
            // showTablePropertiesFormItem1
            // 
            this.showTablePropertiesFormItem1.Id = 158;
            this.showTablePropertiesFormItem1.Name = "showTablePropertiesFormItem1";
            // 
            // deleteTableElementsItem1
            // 
            this.deleteTableElementsItem1.Id = 159;
            this.deleteTableElementsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.showDeleteTableCellsFormItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteTableColumnsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteTableRowsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteTableItem1)});
            this.deleteTableElementsItem1.Name = "deleteTableElementsItem1";
            // 
            // showDeleteTableCellsFormItem1
            // 
            this.showDeleteTableCellsFormItem1.Id = 160;
            this.showDeleteTableCellsFormItem1.Name = "showDeleteTableCellsFormItem1";
            // 
            // deleteTableColumnsItem1
            // 
            this.deleteTableColumnsItem1.Id = 161;
            this.deleteTableColumnsItem1.Name = "deleteTableColumnsItem1";
            // 
            // deleteTableRowsItem1
            // 
            this.deleteTableRowsItem1.Id = 162;
            this.deleteTableRowsItem1.Name = "deleteTableRowsItem1";
            // 
            // deleteTableItem1
            // 
            this.deleteTableItem1.Id = 163;
            this.deleteTableItem1.Name = "deleteTableItem1";
            // 
            // insertTableRowAboveItem1
            // 
            this.insertTableRowAboveItem1.Id = 164;
            this.insertTableRowAboveItem1.Name = "insertTableRowAboveItem1";
            // 
            // insertTableRowBelowItem1
            // 
            this.insertTableRowBelowItem1.Id = 165;
            this.insertTableRowBelowItem1.Name = "insertTableRowBelowItem1";
            // 
            // insertTableColumnToLeftItem1
            // 
            this.insertTableColumnToLeftItem1.Id = 166;
            this.insertTableColumnToLeftItem1.Name = "insertTableColumnToLeftItem1";
            // 
            // insertTableColumnToRightItem1
            // 
            this.insertTableColumnToRightItem1.Id = 167;
            this.insertTableColumnToRightItem1.Name = "insertTableColumnToRightItem1";
            // 
            // mergeTableCellsItem1
            // 
            this.mergeTableCellsItem1.Id = 168;
            this.mergeTableCellsItem1.Name = "mergeTableCellsItem1";
            // 
            // showSplitTableCellsForm1
            // 
            this.showSplitTableCellsForm1.Id = 169;
            this.showSplitTableCellsForm1.Name = "showSplitTableCellsForm1";
            // 
            // splitTableItem1
            // 
            this.splitTableItem1.Id = 170;
            this.splitTableItem1.Name = "splitTableItem1";
            // 
            // toggleTableAutoFitItem1
            // 
            this.toggleTableAutoFitItem1.Id = 171;
            this.toggleTableAutoFitItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableAutoFitContentsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableAutoFitWindowItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableFixedColumnWidthItem1)});
            this.toggleTableAutoFitItem1.Name = "toggleTableAutoFitItem1";
            // 
            // toggleTableAutoFitContentsItem1
            // 
            this.toggleTableAutoFitContentsItem1.Id = 172;
            this.toggleTableAutoFitContentsItem1.Name = "toggleTableAutoFitContentsItem1";
            // 
            // toggleTableAutoFitWindowItem1
            // 
            this.toggleTableAutoFitWindowItem1.Id = 173;
            this.toggleTableAutoFitWindowItem1.Name = "toggleTableAutoFitWindowItem1";
            // 
            // toggleTableFixedColumnWidthItem1
            // 
            this.toggleTableFixedColumnWidthItem1.Id = 174;
            this.toggleTableFixedColumnWidthItem1.Name = "toggleTableFixedColumnWidthItem1";
            // 
            // toggleTableCellsTopLeftAlignmentItem1
            // 
            this.toggleTableCellsTopLeftAlignmentItem1.Id = 175;
            this.toggleTableCellsTopLeftAlignmentItem1.Name = "toggleTableCellsTopLeftAlignmentItem1";
            // 
            // toggleTableCellsMiddleLeftAlignmentItem1
            // 
            this.toggleTableCellsMiddleLeftAlignmentItem1.Id = 176;
            this.toggleTableCellsMiddleLeftAlignmentItem1.Name = "toggleTableCellsMiddleLeftAlignmentItem1";
            // 
            // toggleTableCellsBottomLeftAlignmentItem1
            // 
            this.toggleTableCellsBottomLeftAlignmentItem1.Id = 177;
            this.toggleTableCellsBottomLeftAlignmentItem1.Name = "toggleTableCellsBottomLeftAlignmentItem1";
            // 
            // toggleTableCellsTopCenterAlignmentItem1
            // 
            this.toggleTableCellsTopCenterAlignmentItem1.Id = 178;
            this.toggleTableCellsTopCenterAlignmentItem1.Name = "toggleTableCellsTopCenterAlignmentItem1";
            // 
            // toggleTableCellsMiddleCenterAlignmentItem1
            // 
            this.toggleTableCellsMiddleCenterAlignmentItem1.Id = 179;
            this.toggleTableCellsMiddleCenterAlignmentItem1.Name = "toggleTableCellsMiddleCenterAlignmentItem1";
            // 
            // toggleTableCellsBottomCenterAlignmentItem1
            // 
            this.toggleTableCellsBottomCenterAlignmentItem1.Id = 180;
            this.toggleTableCellsBottomCenterAlignmentItem1.Name = "toggleTableCellsBottomCenterAlignmentItem1";
            // 
            // toggleTableCellsTopRightAlignmentItem1
            // 
            this.toggleTableCellsTopRightAlignmentItem1.Id = 181;
            this.toggleTableCellsTopRightAlignmentItem1.Name = "toggleTableCellsTopRightAlignmentItem1";
            // 
            // toggleTableCellsMiddleRightAlignmentItem1
            // 
            this.toggleTableCellsMiddleRightAlignmentItem1.Id = 182;
            this.toggleTableCellsMiddleRightAlignmentItem1.Name = "toggleTableCellsMiddleRightAlignmentItem1";
            // 
            // toggleTableCellsBottomRightAlignmentItem1
            // 
            this.toggleTableCellsBottomRightAlignmentItem1.Id = 183;
            this.toggleTableCellsBottomRightAlignmentItem1.Name = "toggleTableCellsBottomRightAlignmentItem1";
            // 
            // showTableOptionsFormItem1
            // 
            this.showTableOptionsFormItem1.Id = 184;
            this.showTableOptionsFormItem1.Name = "showTableOptionsFormItem1";
            // 
            // checkSpellingItem1
            // 
            this.checkSpellingItem1.Id = 185;
            this.checkSpellingItem1.Name = "checkSpellingItem1";
            // 
            // insertTableOfContentsItem1
            // 
            this.insertTableOfContentsItem1.Id = 186;
            this.insertTableOfContentsItem1.Name = "insertTableOfContentsItem1";
            // 
            // updateTableOfContentsItem1
            // 
            this.updateTableOfContentsItem1.Id = 187;
            this.updateTableOfContentsItem1.Name = "updateTableOfContentsItem1";
            // 
            // addParagraphsToTableOfContentItem1
            // 
            this.addParagraphsToTableOfContentItem1.Id = 188;
            this.addParagraphsToTableOfContentItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setParagraphHeadingLevelItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setParagraphHeadingLevelItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.setParagraphHeadingLevelItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.setParagraphHeadingLevelItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.setParagraphHeadingLevelItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.setParagraphHeadingLevelItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.setParagraphHeadingLevelItem7),
            new DevExpress.XtraBars.LinkPersistInfo(this.setParagraphHeadingLevelItem8),
            new DevExpress.XtraBars.LinkPersistInfo(this.setParagraphHeadingLevelItem9),
            new DevExpress.XtraBars.LinkPersistInfo(this.setParagraphHeadingLevelItem10)});
            this.addParagraphsToTableOfContentItem1.Name = "addParagraphsToTableOfContentItem1";
            // 
            // setParagraphHeadingLevelItem1
            // 
            this.setParagraphHeadingLevelItem1.Id = 189;
            this.setParagraphHeadingLevelItem1.Name = "setParagraphHeadingLevelItem1";
            this.setParagraphHeadingLevelItem1.OutlineLevel = 0;
            // 
            // setParagraphHeadingLevelItem2
            // 
            this.setParagraphHeadingLevelItem2.Id = 190;
            this.setParagraphHeadingLevelItem2.Name = "setParagraphHeadingLevelItem2";
            this.setParagraphHeadingLevelItem2.OutlineLevel = 1;
            // 
            // setParagraphHeadingLevelItem3
            // 
            this.setParagraphHeadingLevelItem3.Id = 191;
            this.setParagraphHeadingLevelItem3.Name = "setParagraphHeadingLevelItem3";
            this.setParagraphHeadingLevelItem3.OutlineLevel = 2;
            // 
            // setParagraphHeadingLevelItem4
            // 
            this.setParagraphHeadingLevelItem4.Id = 192;
            this.setParagraphHeadingLevelItem4.Name = "setParagraphHeadingLevelItem4";
            this.setParagraphHeadingLevelItem4.OutlineLevel = 3;
            // 
            // setParagraphHeadingLevelItem5
            // 
            this.setParagraphHeadingLevelItem5.Id = 193;
            this.setParagraphHeadingLevelItem5.Name = "setParagraphHeadingLevelItem5";
            this.setParagraphHeadingLevelItem5.OutlineLevel = 4;
            // 
            // setParagraphHeadingLevelItem6
            // 
            this.setParagraphHeadingLevelItem6.Id = 194;
            this.setParagraphHeadingLevelItem6.Name = "setParagraphHeadingLevelItem6";
            this.setParagraphHeadingLevelItem6.OutlineLevel = 5;
            // 
            // setParagraphHeadingLevelItem7
            // 
            this.setParagraphHeadingLevelItem7.Id = 195;
            this.setParagraphHeadingLevelItem7.Name = "setParagraphHeadingLevelItem7";
            this.setParagraphHeadingLevelItem7.OutlineLevel = 6;
            // 
            // setParagraphHeadingLevelItem8
            // 
            this.setParagraphHeadingLevelItem8.Id = 196;
            this.setParagraphHeadingLevelItem8.Name = "setParagraphHeadingLevelItem8";
            this.setParagraphHeadingLevelItem8.OutlineLevel = 7;
            // 
            // setParagraphHeadingLevelItem9
            // 
            this.setParagraphHeadingLevelItem9.Id = 197;
            this.setParagraphHeadingLevelItem9.Name = "setParagraphHeadingLevelItem9";
            this.setParagraphHeadingLevelItem9.OutlineLevel = 8;
            // 
            // setParagraphHeadingLevelItem10
            // 
            this.setParagraphHeadingLevelItem10.Id = 198;
            this.setParagraphHeadingLevelItem10.Name = "setParagraphHeadingLevelItem10";
            this.setParagraphHeadingLevelItem10.OutlineLevel = 9;
            // 
            // insertCaptionPlaceholderItem1
            // 
            this.insertCaptionPlaceholderItem1.Id = 199;
            this.insertCaptionPlaceholderItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.insertFiguresCaptionItems1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertTablesCaptionItems1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertEquationsCaptionItems1)});
            this.insertCaptionPlaceholderItem1.Name = "insertCaptionPlaceholderItem1";
            // 
            // insertFiguresCaptionItems1
            // 
            this.insertFiguresCaptionItems1.Id = 200;
            this.insertFiguresCaptionItems1.Name = "insertFiguresCaptionItems1";
            // 
            // insertTablesCaptionItems1
            // 
            this.insertTablesCaptionItems1.Id = 201;
            this.insertTablesCaptionItems1.Name = "insertTablesCaptionItems1";
            // 
            // insertEquationsCaptionItems1
            // 
            this.insertEquationsCaptionItems1.Id = 202;
            this.insertEquationsCaptionItems1.Name = "insertEquationsCaptionItems1";
            // 
            // insertTableOfFiguresPlaceholderItem1
            // 
            this.insertTableOfFiguresPlaceholderItem1.Id = 203;
            this.insertTableOfFiguresPlaceholderItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.insertTableOfFiguresItems1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertTableOfTablesItems1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertTableOfEquationsItems1)});
            this.insertTableOfFiguresPlaceholderItem1.Name = "insertTableOfFiguresPlaceholderItem1";
            // 
            // insertTableOfFiguresItems1
            // 
            this.insertTableOfFiguresItems1.Id = 204;
            this.insertTableOfFiguresItems1.Name = "insertTableOfFiguresItems1";
            // 
            // insertTableOfTablesItems1
            // 
            this.insertTableOfTablesItems1.Id = 205;
            this.insertTableOfTablesItems1.Name = "insertTableOfTablesItems1";
            // 
            // insertTableOfEquationsItems1
            // 
            this.insertTableOfEquationsItems1.Id = 206;
            this.insertTableOfEquationsItems1.Name = "insertTableOfEquationsItems1";
            // 
            // updateTableOfFiguresItem1
            // 
            this.updateTableOfFiguresItem1.Id = 207;
            this.updateTableOfFiguresItem1.Name = "updateTableOfFiguresItem1";
            // 
            // changeFloatingObjectFillColorItem1
            // 
            this.changeFloatingObjectFillColorItem1.Id = 208;
            this.changeFloatingObjectFillColorItem1.Name = "changeFloatingObjectFillColorItem1";
            // 
            // changeFloatingObjectOutlineColorItem1
            // 
            this.changeFloatingObjectOutlineColorItem1.Id = 209;
            this.changeFloatingObjectOutlineColorItem1.Name = "changeFloatingObjectOutlineColorItem1";
            // 
            // changeFloatingObjectOutlineWeightItem1
            // 
            this.changeFloatingObjectOutlineWeightItem1.Edit = this.repositoryItemFloatingObjectOutlineWeight1;
            this.changeFloatingObjectOutlineWeightItem1.EditValue = 20;
            this.changeFloatingObjectOutlineWeightItem1.Id = 210;
            this.changeFloatingObjectOutlineWeightItem1.Name = "changeFloatingObjectOutlineWeightItem1";
            // 
            // repositoryItemFloatingObjectOutlineWeight1
            // 
            this.repositoryItemFloatingObjectOutlineWeight1.AutoHeight = false;
            this.repositoryItemFloatingObjectOutlineWeight1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFloatingObjectOutlineWeight1.Control = this.snapControl1;
            this.repositoryItemFloatingObjectOutlineWeight1.Name = "repositoryItemFloatingObjectOutlineWeight1";
            // 
            // changeFloatingObjectTextWrapTypeItem1
            // 
            this.changeFloatingObjectTextWrapTypeItem1.Id = 211;
            this.changeFloatingObjectTextWrapTypeItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectSquareTextWrapTypeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectTightTextWrapTypeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectThroughTextWrapTypeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectTopAndBottomTextWrapTypeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectBehindTextWrapTypeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectInFrontOfTextWrapTypeItem1)});
            this.changeFloatingObjectTextWrapTypeItem1.Name = "changeFloatingObjectTextWrapTypeItem1";
            // 
            // setFloatingObjectSquareTextWrapTypeItem1
            // 
            this.setFloatingObjectSquareTextWrapTypeItem1.Id = 212;
            this.setFloatingObjectSquareTextWrapTypeItem1.Name = "setFloatingObjectSquareTextWrapTypeItem1";
            // 
            // setFloatingObjectTightTextWrapTypeItem1
            // 
            this.setFloatingObjectTightTextWrapTypeItem1.Id = 213;
            this.setFloatingObjectTightTextWrapTypeItem1.Name = "setFloatingObjectTightTextWrapTypeItem1";
            // 
            // setFloatingObjectThroughTextWrapTypeItem1
            // 
            this.setFloatingObjectThroughTextWrapTypeItem1.Id = 214;
            this.setFloatingObjectThroughTextWrapTypeItem1.Name = "setFloatingObjectThroughTextWrapTypeItem1";
            // 
            // setFloatingObjectTopAndBottomTextWrapTypeItem1
            // 
            this.setFloatingObjectTopAndBottomTextWrapTypeItem1.Id = 215;
            this.setFloatingObjectTopAndBottomTextWrapTypeItem1.Name = "setFloatingObjectTopAndBottomTextWrapTypeItem1";
            // 
            // setFloatingObjectBehindTextWrapTypeItem1
            // 
            this.setFloatingObjectBehindTextWrapTypeItem1.Id = 216;
            this.setFloatingObjectBehindTextWrapTypeItem1.Name = "setFloatingObjectBehindTextWrapTypeItem1";
            // 
            // setFloatingObjectInFrontOfTextWrapTypeItem1
            // 
            this.setFloatingObjectInFrontOfTextWrapTypeItem1.Id = 217;
            this.setFloatingObjectInFrontOfTextWrapTypeItem1.Name = "setFloatingObjectInFrontOfTextWrapTypeItem1";
            // 
            // changeFloatingObjectAlignmentItem1
            // 
            this.changeFloatingObjectAlignmentItem1.Id = 218;
            this.changeFloatingObjectAlignmentItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectTopLeftAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectTopCenterAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectTopRightAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectMiddleLeftAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectMiddleCenterAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectMiddleRightAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectBottomLeftAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectBottomCenterAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectBottomRightAlignmentItem1)});
            this.changeFloatingObjectAlignmentItem1.Name = "changeFloatingObjectAlignmentItem1";
            // 
            // setFloatingObjectTopLeftAlignmentItem1
            // 
            this.setFloatingObjectTopLeftAlignmentItem1.Id = 219;
            this.setFloatingObjectTopLeftAlignmentItem1.Name = "setFloatingObjectTopLeftAlignmentItem1";
            // 
            // setFloatingObjectTopCenterAlignmentItem1
            // 
            this.setFloatingObjectTopCenterAlignmentItem1.Id = 220;
            this.setFloatingObjectTopCenterAlignmentItem1.Name = "setFloatingObjectTopCenterAlignmentItem1";
            // 
            // setFloatingObjectTopRightAlignmentItem1
            // 
            this.setFloatingObjectTopRightAlignmentItem1.Id = 221;
            this.setFloatingObjectTopRightAlignmentItem1.Name = "setFloatingObjectTopRightAlignmentItem1";
            // 
            // setFloatingObjectMiddleLeftAlignmentItem1
            // 
            this.setFloatingObjectMiddleLeftAlignmentItem1.Id = 222;
            this.setFloatingObjectMiddleLeftAlignmentItem1.Name = "setFloatingObjectMiddleLeftAlignmentItem1";
            // 
            // setFloatingObjectMiddleCenterAlignmentItem1
            // 
            this.setFloatingObjectMiddleCenterAlignmentItem1.Id = 223;
            this.setFloatingObjectMiddleCenterAlignmentItem1.Name = "setFloatingObjectMiddleCenterAlignmentItem1";
            // 
            // setFloatingObjectMiddleRightAlignmentItem1
            // 
            this.setFloatingObjectMiddleRightAlignmentItem1.Id = 224;
            this.setFloatingObjectMiddleRightAlignmentItem1.Name = "setFloatingObjectMiddleRightAlignmentItem1";
            // 
            // setFloatingObjectBottomLeftAlignmentItem1
            // 
            this.setFloatingObjectBottomLeftAlignmentItem1.Id = 225;
            this.setFloatingObjectBottomLeftAlignmentItem1.Name = "setFloatingObjectBottomLeftAlignmentItem1";
            // 
            // setFloatingObjectBottomCenterAlignmentItem1
            // 
            this.setFloatingObjectBottomCenterAlignmentItem1.Id = 226;
            this.setFloatingObjectBottomCenterAlignmentItem1.Name = "setFloatingObjectBottomCenterAlignmentItem1";
            // 
            // setFloatingObjectBottomRightAlignmentItem1
            // 
            this.setFloatingObjectBottomRightAlignmentItem1.Id = 227;
            this.setFloatingObjectBottomRightAlignmentItem1.Name = "setFloatingObjectBottomRightAlignmentItem1";
            // 
            // floatingObjectBringForwardSubItem1
            // 
            this.floatingObjectBringForwardSubItem1.Id = 228;
            this.floatingObjectBringForwardSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.floatingObjectBringForwardItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.floatingObjectBringToFrontItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.floatingObjectBringInFrontOfTextItem1)});
            this.floatingObjectBringForwardSubItem1.Name = "floatingObjectBringForwardSubItem1";
            // 
            // floatingObjectBringForwardItem1
            // 
            this.floatingObjectBringForwardItem1.Id = 229;
            this.floatingObjectBringForwardItem1.Name = "floatingObjectBringForwardItem1";
            // 
            // floatingObjectBringToFrontItem1
            // 
            this.floatingObjectBringToFrontItem1.Id = 230;
            this.floatingObjectBringToFrontItem1.Name = "floatingObjectBringToFrontItem1";
            // 
            // floatingObjectBringInFrontOfTextItem1
            // 
            this.floatingObjectBringInFrontOfTextItem1.Id = 231;
            this.floatingObjectBringInFrontOfTextItem1.Name = "floatingObjectBringInFrontOfTextItem1";
            // 
            // floatingObjectSendBackwardSubItem1
            // 
            this.floatingObjectSendBackwardSubItem1.Id = 232;
            this.floatingObjectSendBackwardSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.floatingObjectSendBackwardItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.floatingObjectSendToBackItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.floatingObjectSendBehindTextItem1)});
            this.floatingObjectSendBackwardSubItem1.Name = "floatingObjectSendBackwardSubItem1";
            // 
            // floatingObjectSendBackwardItem1
            // 
            this.floatingObjectSendBackwardItem1.Id = 233;
            this.floatingObjectSendBackwardItem1.Name = "floatingObjectSendBackwardItem1";
            // 
            // floatingObjectSendToBackItem1
            // 
            this.floatingObjectSendToBackItem1.Id = 234;
            this.floatingObjectSendToBackItem1.Name = "floatingObjectSendToBackItem1";
            // 
            // floatingObjectSendBehindTextItem1
            // 
            this.floatingObjectSendBehindTextItem1.Id = 235;
            this.floatingObjectSendBehindTextItem1.Name = "floatingObjectSendBehindTextItem1";
            // 
            // themesGalleryBarItem1
            // 
            // 
            // 
            // 
            this.themesGalleryBarItem1.Gallery.ColumnCount = 7;
            this.themesGalleryBarItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.themesGalleryBarItem1.Gallery.RowCount = 1;
            this.themesGalleryBarItem1.Id = 236;
            this.themesGalleryBarItem1.Name = "themesGalleryBarItem1";
            // 
            // commandBarCheckItem2
            // 
            this.commandBarCheckItem2.Id = 237;
            this.commandBarCheckItem2.Name = "commandBarCheckItem2";
            this.commandBarCheckItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.commandBarCheckItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupByField;
            // 
            // commandBarCheckItem3
            // 
            this.commandBarCheckItem3.Id = 238;
            this.commandBarCheckItem3.Name = "commandBarCheckItem3";
            this.commandBarCheckItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SortFieldAscending;
            // 
            // commandBarCheckItem4
            // 
            this.commandBarCheckItem4.Id = 239;
            this.commandBarCheckItem4.Name = "commandBarCheckItem4";
            this.commandBarCheckItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SortFieldDescending;
            // 
            // commandBarSubItem1
            // 
            this.commandBarSubItem1.Id = 240;
            this.commandBarSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem7),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem8),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem9)});
            this.commandBarSubItem1.Name = "commandBarSubItem1";
            this.commandBarSubItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryByField;
            // 
            // commandBarCheckItem5
            // 
            this.commandBarCheckItem5.Id = 241;
            this.commandBarCheckItem5.Name = "commandBarCheckItem5";
            this.commandBarCheckItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryCount;
            // 
            // commandBarCheckItem6
            // 
            this.commandBarCheckItem6.Id = 242;
            this.commandBarCheckItem6.Name = "commandBarCheckItem6";
            this.commandBarCheckItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummarySum;
            // 
            // commandBarCheckItem7
            // 
            this.commandBarCheckItem7.Id = 243;
            this.commandBarCheckItem7.Name = "commandBarCheckItem7";
            this.commandBarCheckItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryAverage;
            // 
            // commandBarCheckItem8
            // 
            this.commandBarCheckItem8.Id = 244;
            this.commandBarCheckItem8.Name = "commandBarCheckItem8";
            this.commandBarCheckItem8.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryMax;
            // 
            // commandBarCheckItem9
            // 
            this.commandBarCheckItem9.Id = 245;
            this.commandBarCheckItem9.Name = "commandBarCheckItem9";
            this.commandBarCheckItem9.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryMin;
            // 
            // filterPopupButtonItem1
            // 
            this.filterPopupButtonItem1.ActAsDropDown = true;
            this.filterPopupButtonItem1.Id = 246;
            this.filterPopupButtonItem1.Name = "filterPopupButtonItem1";
            // 
            // propertiesBarButtonItem1
            // 
            this.propertiesBarButtonItem1.ActAsDropDown = true;
            this.propertiesBarButtonItem1.Id = 247;
            this.propertiesBarButtonItem1.Name = "propertiesBarButtonItem1";
            this.propertiesBarButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // commandBarSubItem2
            // 
            this.commandBarSubItem2.Id = 248;
            this.commandBarSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem10),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem11)});
            this.commandBarSubItem2.Name = "commandBarSubItem2";
            this.commandBarSubItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.commandBarSubItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupHeader;
            // 
            // commandBarCheckItem10
            // 
            this.commandBarCheckItem10.Id = 249;
            this.commandBarCheckItem10.Name = "commandBarCheckItem10";
            this.commandBarCheckItem10.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertGroupHeader;
            // 
            // commandBarCheckItem11
            // 
            this.commandBarCheckItem11.Id = 250;
            this.commandBarCheckItem11.Name = "commandBarCheckItem11";
            this.commandBarCheckItem11.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveGroupHeader;
            // 
            // commandBarSubItem3
            // 
            this.commandBarSubItem3.Id = 251;
            this.commandBarSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem12),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem13)});
            this.commandBarSubItem3.Name = "commandBarSubItem3";
            this.commandBarSubItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupFooter;
            // 
            // commandBarCheckItem12
            // 
            this.commandBarCheckItem12.Id = 252;
            this.commandBarCheckItem12.Name = "commandBarCheckItem12";
            this.commandBarCheckItem12.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertGroupFooter;
            // 
            // commandBarCheckItem13
            // 
            this.commandBarCheckItem13.Id = 253;
            this.commandBarCheckItem13.Name = "commandBarCheckItem13";
            this.commandBarCheckItem13.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveGroupFooter;
            // 
            // commandBarItem6
            // 
            this.commandBarItem6.Id = 254;
            this.commandBarItem6.Name = "commandBarItem6";
            this.commandBarItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupFieldsCollection;
            // 
            // commandBarItem7
            // 
            this.commandBarItem7.Id = 255;
            this.commandBarItem7.Name = "commandBarItem7";
            this.commandBarItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ShowReportStructureEditorForm;
            // 
            // commandBarSubItem4
            // 
            this.commandBarSubItem4.Id = 256;
            this.commandBarSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem14),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem15),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem16),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem17),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem18),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem19),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem20)});
            this.commandBarSubItem4.Name = "commandBarSubItem4";
            this.commandBarSubItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertGroupSeparator;
            // 
            // commandBarCheckItem14
            // 
            this.commandBarCheckItem14.Id = 257;
            this.commandBarCheckItem14.Name = "commandBarCheckItem14";
            this.commandBarCheckItem14.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertPageBreakGroupSeparator;
            // 
            // commandBarCheckItem15
            // 
            this.commandBarCheckItem15.Id = 258;
            this.commandBarCheckItem15.Name = "commandBarCheckItem15";
            this.commandBarCheckItem15.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakNextPageGroupSeparator;
            // 
            // commandBarCheckItem16
            // 
            this.commandBarCheckItem16.Id = 259;
            this.commandBarCheckItem16.Name = "commandBarCheckItem16";
            this.commandBarCheckItem16.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakEvenPageGroupSeparator;
            // 
            // commandBarCheckItem17
            // 
            this.commandBarCheckItem17.Id = 260;
            this.commandBarCheckItem17.Name = "commandBarCheckItem17";
            this.commandBarCheckItem17.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakOddPageGroupSeparator;
            // 
            // commandBarCheckItem18
            // 
            this.commandBarCheckItem18.Id = 261;
            this.commandBarCheckItem18.Name = "commandBarCheckItem18";
            this.commandBarCheckItem18.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyParagraphGroupSeparator;
            // 
            // commandBarCheckItem19
            // 
            this.commandBarCheckItem19.Id = 262;
            this.commandBarCheckItem19.Name = "commandBarCheckItem19";
            this.commandBarCheckItem19.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyRowGroupSeparator;
            // 
            // commandBarCheckItem20
            // 
            this.commandBarCheckItem20.Id = 263;
            this.commandBarCheckItem20.Name = "commandBarCheckItem20";
            this.commandBarCheckItem20.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertNoneGroupSeparator;
            // 
            // commandBarSubItem5
            // 
            this.commandBarSubItem5.Id = 264;
            this.commandBarSubItem5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem21),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem22)});
            this.commandBarSubItem5.Name = "commandBarSubItem5";
            this.commandBarSubItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.commandBarSubItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ListHeader;
            // 
            // commandBarCheckItem21
            // 
            this.commandBarCheckItem21.Id = 265;
            this.commandBarCheckItem21.Name = "commandBarCheckItem21";
            this.commandBarCheckItem21.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertListHeader;
            // 
            // commandBarCheckItem22
            // 
            this.commandBarCheckItem22.Id = 266;
            this.commandBarCheckItem22.Name = "commandBarCheckItem22";
            this.commandBarCheckItem22.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveListHeader;
            // 
            // commandBarSubItem6
            // 
            this.commandBarSubItem6.Id = 267;
            this.commandBarSubItem6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem23),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem24)});
            this.commandBarSubItem6.Name = "commandBarSubItem6";
            this.commandBarSubItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.commandBarSubItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ListFooter;
            // 
            // commandBarCheckItem23
            // 
            this.commandBarCheckItem23.Id = 268;
            this.commandBarCheckItem23.Name = "commandBarCheckItem23";
            this.commandBarCheckItem23.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertListFooter;
            // 
            // commandBarCheckItem24
            // 
            this.commandBarCheckItem24.Id = 269;
            this.commandBarCheckItem24.Name = "commandBarCheckItem24";
            this.commandBarCheckItem24.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveListFooter;
            // 
            // commandBarItem8
            // 
            this.commandBarItem8.Id = 270;
            this.commandBarItem8.Name = "commandBarItem8";
            this.commandBarItem8.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.FilterList;
            // 
            // commandBarItem9
            // 
            this.commandBarItem9.Id = 271;
            this.commandBarItem9.Name = "commandBarItem9";
            this.commandBarItem9.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ConvertToParagraphs;
            // 
            // commandBarSubItem7
            // 
            this.commandBarSubItem7.Id = 272;
            this.commandBarSubItem7.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem25),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem26),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem27),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem28),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem29),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem30),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem31)});
            this.commandBarSubItem7.Name = "commandBarSubItem7";
            this.commandBarSubItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertDataRowSeparator;
            // 
            // commandBarCheckItem25
            // 
            this.commandBarCheckItem25.Id = 273;
            this.commandBarCheckItem25.Name = "commandBarCheckItem25";
            this.commandBarCheckItem25.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertPageBreakDataRowSeparator;
            // 
            // commandBarCheckItem26
            // 
            this.commandBarCheckItem26.Id = 274;
            this.commandBarCheckItem26.Name = "commandBarCheckItem26";
            this.commandBarCheckItem26.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakNextPageDataRowSeparator;
            // 
            // commandBarCheckItem27
            // 
            this.commandBarCheckItem27.Id = 275;
            this.commandBarCheckItem27.Name = "commandBarCheckItem27";
            this.commandBarCheckItem27.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakEvenPageDataRowSeparator;
            // 
            // commandBarCheckItem28
            // 
            this.commandBarCheckItem28.Id = 276;
            this.commandBarCheckItem28.Name = "commandBarCheckItem28";
            this.commandBarCheckItem28.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakOddPageDataRowSeparator;
            // 
            // commandBarCheckItem29
            // 
            this.commandBarCheckItem29.Id = 277;
            this.commandBarCheckItem29.Name = "commandBarCheckItem29";
            this.commandBarCheckItem29.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyParagraphDataRowSeparator;
            // 
            // commandBarCheckItem30
            // 
            this.commandBarCheckItem30.Id = 278;
            this.commandBarCheckItem30.Name = "commandBarCheckItem30";
            this.commandBarCheckItem30.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyRowDataRowSeparator;
            // 
            // commandBarCheckItem31
            // 
            this.commandBarCheckItem31.Id = 279;
            this.commandBarCheckItem31.Name = "commandBarCheckItem31";
            this.commandBarCheckItem31.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertNoneDataRowSeparator;
            // 
            // commandBarItem10
            // 
            this.commandBarItem10.Id = 280;
            this.commandBarItem10.Name = "commandBarItem10";
            this.commandBarItem10.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.DeleteList;
            // 
            // barButtonGroup8
            // 
            this.barButtonGroup8.Id = 8;
            this.barButtonGroup8.ItemLinks.Add(this.changeEditorRowLimitItem1);
            this.barButtonGroup8.Name = "barButtonGroup8";
            this.barButtonGroup8.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}";
            // 
            // changeEditorRowLimitItem1
            // 
            this.changeEditorRowLimitItem1.Edit = this.repositoryItemEditorRowLimitEdit1;
            this.changeEditorRowLimitItem1.Id = 281;
            this.changeEditorRowLimitItem1.Name = "changeEditorRowLimitItem1";
            this.changeEditorRowLimitItem1.Width = 90;
            // 
            // repositoryItemEditorRowLimitEdit1
            // 
            this.repositoryItemEditorRowLimitEdit1.AutoHeight = false;
            this.repositoryItemEditorRowLimitEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemEditorRowLimitEdit1.Control = this.snapControl1;
            this.repositoryItemEditorRowLimitEdit1.Name = "repositoryItemEditorRowLimitEdit1";
            // 
            // createBarBaseItem1
            // 
            this.createBarBaseItem1.Id = 282;
            this.createBarBaseItem1.Name = "createBarBaseItem1";
            // 
            // createLineBaseItem1
            // 
            this.createLineBaseItem1.Id = 283;
            this.createLineBaseItem1.Name = "createLineBaseItem1";
            // 
            // createPieBaseItem1
            // 
            this.createPieBaseItem1.Id = 284;
            this.createPieBaseItem1.Name = "createPieBaseItem1";
            // 
            // createRotatedBarBaseItem1
            // 
            this.createRotatedBarBaseItem1.Id = 285;
            this.createRotatedBarBaseItem1.Name = "createRotatedBarBaseItem1";
            // 
            // createAreaBaseItem1
            // 
            this.createAreaBaseItem1.Id = 286;
            this.createAreaBaseItem1.Name = "createAreaBaseItem1";
            // 
            // createOtherSeriesTypesBaseItem1
            // 
            this.createOtherSeriesTypesBaseItem1.Id = 287;
            this.createOtherSeriesTypesBaseItem1.Name = "createOtherSeriesTypesBaseItem1";
            // 
            // changePaletteGalleryBaseItem1
            // 
            this.changePaletteGalleryBaseItem1.Id = 288;
            this.changePaletteGalleryBaseItem1.Name = "changePaletteGalleryBaseItem1";
            // 
            // changeAppearanceGalleryBaseItem1
            // 
            // 
            // 
            // 
            this.changeAppearanceGalleryBaseItem1.Gallery.ColumnCount = 7;
            this.changeAppearanceGalleryBaseItem1.Gallery.ImageSize = new System.Drawing.Size(80, 50);
            this.changeAppearanceGalleryBaseItem1.Gallery.RowCount = 4;
            this.changeAppearanceGalleryBaseItem1.Id = 289;
            this.changeAppearanceGalleryBaseItem1.Name = "changeAppearanceGalleryBaseItem1";
            // 
            // runWizardChartItem1
            // 
            this.runWizardChartItem1.Id = 290;
            this.runWizardChartItem1.Name = "runWizardChartItem1";
            // 
            // headerFooterToolsRibbonPageCategory1
            // 
            this.headerFooterToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(176)))), ((int)(((byte)(35)))));
            this.headerFooterToolsRibbonPageCategory1.Control = this.snapControl1;
            this.headerFooterToolsRibbonPageCategory1.Name = "headerFooterToolsRibbonPageCategory1";
            this.headerFooterToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.headerFooterToolsDesignRibbonPage1});
            this.headerFooterToolsRibbonPageCategory1.Visible = false;
            // 
            // headerFooterToolsDesignRibbonPage1
            // 
            this.headerFooterToolsDesignRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.headerFooterToolsDesignNavigationRibbonPageGroup1,
            this.headerFooterToolsDesignOptionsRibbonPageGroup1,
            this.headerFooterToolsDesignCloseRibbonPageGroup1});
            this.headerFooterToolsDesignRibbonPage1.Name = "headerFooterToolsDesignRibbonPage1";
            this.headerFooterToolsDesignRibbonPage1.Visible = false;
            // 
            // headerFooterToolsDesignNavigationRibbonPageGroup1
            // 
            this.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(this.goToPageHeaderItem1);
            this.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(this.goToPageFooterItem1);
            this.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(this.goToNextHeaderFooterItem1);
            this.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(this.goToPreviousHeaderFooterItem1);
            this.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(this.toggleLinkToPreviousItem1);
            this.headerFooterToolsDesignNavigationRibbonPageGroup1.Name = "headerFooterToolsDesignNavigationRibbonPageGroup1";
            // 
            // headerFooterToolsDesignOptionsRibbonPageGroup1
            // 
            this.headerFooterToolsDesignOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleDifferentFirstPageItem1);
            this.headerFooterToolsDesignOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleDifferentOddAndEvenPagesItem1);
            this.headerFooterToolsDesignOptionsRibbonPageGroup1.Name = "headerFooterToolsDesignOptionsRibbonPageGroup1";
            // 
            // headerFooterToolsDesignCloseRibbonPageGroup1
            // 
            this.headerFooterToolsDesignCloseRibbonPageGroup1.ItemLinks.Add(this.closePageHeaderFooterItem1);
            this.headerFooterToolsDesignCloseRibbonPageGroup1.Name = "headerFooterToolsDesignCloseRibbonPageGroup1";
            // 
            // tableToolsRibbonPageCategory1
            // 
            this.tableToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(20)))));
            this.tableToolsRibbonPageCategory1.Control = this.snapControl1;
            this.tableToolsRibbonPageCategory1.Name = "tableToolsRibbonPageCategory1";
            this.tableToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.tableDesignRibbonPage1,
            this.tableLayoutRibbonPage1});
            this.tableToolsRibbonPageCategory1.Visible = false;
            // 
            // tableDesignRibbonPage1
            // 
            this.tableDesignRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.tableStyleOptionsRibbonPageGroup1,
            this.tableStylesRibbonPageGroup1,
            this.tableCellStylesRibbonPageGroup1,
            this.tableDrawBordersRibbonPageGroup1});
            this.tableDesignRibbonPage1.Name = "tableDesignRibbonPage1";
            this.tableDesignRibbonPage1.Visible = false;
            // 
            // tableStyleOptionsRibbonPageGroup1
            // 
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleFirstRowItem1);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleLastRowItem1);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleBandedRowsItem1);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleFirstColumnItem1);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleLastColumnItem1);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleBandedColumnsItem1);
            this.tableStyleOptionsRibbonPageGroup1.Name = "tableStyleOptionsRibbonPageGroup1";
            // 
            // tableStylesRibbonPageGroup1
            // 
            this.tableStylesRibbonPageGroup1.ItemLinks.Add(this.galleryChangeTableStyleItem1);
            this.tableStylesRibbonPageGroup1.Name = "tableStylesRibbonPageGroup1";
            // 
            // tableCellStylesRibbonPageGroup1
            // 
            this.tableCellStylesRibbonPageGroup1.ItemLinks.Add(this.galleryChangeTableCellStyleItem1);
            this.tableCellStylesRibbonPageGroup1.Name = "tableCellStylesRibbonPageGroup1";
            // 
            // tableDrawBordersRibbonPageGroup1
            // 
            this.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(this.changeTableBorderLineStyleItem1);
            this.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(this.changeTableBorderLineWeightItem1);
            this.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(this.changeTableBorderColorItem1);
            this.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(this.changeTableBordersItem1);
            this.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(this.changeTableCellsShadingItem1);
            this.tableDrawBordersRibbonPageGroup1.Name = "tableDrawBordersRibbonPageGroup1";
            // 
            // tableLayoutRibbonPage1
            // 
            this.tableLayoutRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.tableTableRibbonPageGroup1,
            this.tableRowsAndColumnsRibbonPageGroup1,
            this.tableMergeRibbonPageGroup1,
            this.tableCellSizeRibbonPageGroup1,
            this.tableAlignmentRibbonPageGroup1});
            this.tableLayoutRibbonPage1.Name = "tableLayoutRibbonPage1";
            this.tableLayoutRibbonPage1.Visible = false;
            // 
            // tableTableRibbonPageGroup1
            // 
            this.tableTableRibbonPageGroup1.ItemLinks.Add(this.selectTableElementsItem1);
            this.tableTableRibbonPageGroup1.ItemLinks.Add(this.toggleShowTableGridLinesItem1);
            this.tableTableRibbonPageGroup1.ItemLinks.Add(this.showTablePropertiesFormItem1);
            this.tableTableRibbonPageGroup1.Name = "tableTableRibbonPageGroup1";
            // 
            // tableRowsAndColumnsRibbonPageGroup1
            // 
            this.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(this.deleteTableElementsItem1);
            this.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(this.insertTableRowAboveItem1);
            this.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(this.insertTableRowBelowItem1);
            this.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(this.insertTableColumnToLeftItem1);
            this.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(this.insertTableColumnToRightItem1);
            this.tableRowsAndColumnsRibbonPageGroup1.Name = "tableRowsAndColumnsRibbonPageGroup1";
            // 
            // tableMergeRibbonPageGroup1
            // 
            this.tableMergeRibbonPageGroup1.ItemLinks.Add(this.mergeTableCellsItem1);
            this.tableMergeRibbonPageGroup1.ItemLinks.Add(this.showSplitTableCellsForm1);
            this.tableMergeRibbonPageGroup1.ItemLinks.Add(this.splitTableItem1);
            this.tableMergeRibbonPageGroup1.Name = "tableMergeRibbonPageGroup1";
            // 
            // tableCellSizeRibbonPageGroup1
            // 
            this.tableCellSizeRibbonPageGroup1.ItemLinks.Add(this.toggleTableAutoFitItem1);
            this.tableCellSizeRibbonPageGroup1.Name = "tableCellSizeRibbonPageGroup1";
            // 
            // tableAlignmentRibbonPageGroup1
            // 
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsTopLeftAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsMiddleLeftAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsBottomLeftAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsTopCenterAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsMiddleCenterAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsBottomCenterAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsTopRightAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsMiddleRightAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsBottomRightAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.showTableOptionsFormItem1);
            this.tableAlignmentRibbonPageGroup1.Name = "tableAlignmentRibbonPageGroup1";
            // 
            // floatingPictureToolsRibbonPageCategory1
            // 
            this.floatingPictureToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(0)))), ((int)(((byte)(119)))));
            this.floatingPictureToolsRibbonPageCategory1.Control = this.snapControl1;
            this.floatingPictureToolsRibbonPageCategory1.Name = "floatingPictureToolsRibbonPageCategory1";
            this.floatingPictureToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.floatingPictureToolsFormatPage1});
            this.floatingPictureToolsRibbonPageCategory1.Visible = false;
            // 
            // floatingPictureToolsFormatPage1
            // 
            this.floatingPictureToolsFormatPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.floatingPictureToolsShapeStylesPageGroup1,
            this.floatingPictureToolsArrangePageGroup1});
            this.floatingPictureToolsFormatPage1.Name = "floatingPictureToolsFormatPage1";
            this.floatingPictureToolsFormatPage1.Visible = false;
            // 
            // floatingPictureToolsShapeStylesPageGroup1
            // 
            this.floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(this.changeFloatingObjectFillColorItem1);
            this.floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(this.changeFloatingObjectOutlineColorItem1);
            this.floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(this.changeFloatingObjectOutlineWeightItem1);
            this.floatingPictureToolsShapeStylesPageGroup1.Name = "floatingPictureToolsShapeStylesPageGroup1";
            // 
            // floatingPictureToolsArrangePageGroup1
            // 
            this.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(this.changeFloatingObjectTextWrapTypeItem1);
            this.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(this.changeFloatingObjectAlignmentItem1);
            this.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(this.floatingObjectBringForwardSubItem1);
            this.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(this.floatingObjectSendBackwardSubItem1);
            this.floatingPictureToolsArrangePageGroup1.Name = "floatingPictureToolsArrangePageGroup1";
            // 
            // dataToolsRibbonPageCategory1
            // 
            this.dataToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(166)))), ((int)(((byte)(207)))));
            this.dataToolsRibbonPageCategory1.Control = this.snapControl1;
            this.dataToolsRibbonPageCategory1.Name = "dataToolsRibbonPageCategory1";
            this.dataToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.appearanceRibbonPage1,
            this.snMergeFieldToolsRibbonPage1,
            this.groupToolsRibbonPage1,
            this.listToolsRibbonPage1});
            // 
            // appearanceRibbonPage1
            // 
            this.appearanceRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.themesRibbonPageGroup1});
            this.appearanceRibbonPage1.Name = "appearanceRibbonPage1";
            // 
            // themesRibbonPageGroup1
            // 
            this.themesRibbonPageGroup1.ItemLinks.Add(this.themesGalleryBarItem1);
            this.themesRibbonPageGroup1.Name = "themesRibbonPageGroup1";
            // 
            // snMergeFieldToolsRibbonPage1
            // 
            this.snMergeFieldToolsRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.dataShapingRibbonPageGroup1,
            this.snMergeFieldPropertiesRibbonPageGroup1});
            this.snMergeFieldToolsRibbonPage1.Name = "snMergeFieldToolsRibbonPage1";
            // 
            // dataShapingRibbonPageGroup1
            // 
            this.dataShapingRibbonPageGroup1.ItemLinks.Add(this.commandBarCheckItem2);
            this.dataShapingRibbonPageGroup1.ItemLinks.Add(this.commandBarCheckItem3);
            this.dataShapingRibbonPageGroup1.ItemLinks.Add(this.commandBarCheckItem4);
            this.dataShapingRibbonPageGroup1.ItemLinks.Add(this.commandBarSubItem1);
            this.dataShapingRibbonPageGroup1.ItemLinks.Add(this.filterPopupButtonItem1);
            this.dataShapingRibbonPageGroup1.Name = "dataShapingRibbonPageGroup1";
            // 
            // snMergeFieldPropertiesRibbonPageGroup1
            // 
            this.snMergeFieldPropertiesRibbonPageGroup1.ItemLinks.Add(this.propertiesBarButtonItem1);
            this.snMergeFieldPropertiesRibbonPageGroup1.Name = "snMergeFieldPropertiesRibbonPageGroup1";
            // 
            // groupToolsRibbonPage1
            // 
            this.groupToolsRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.groupingRibbonPageGroup1});
            this.groupToolsRibbonPage1.Name = "groupToolsRibbonPage1";
            // 
            // groupingRibbonPageGroup1
            // 
            this.groupingRibbonPageGroup1.ItemLinks.Add(this.commandBarSubItem2);
            this.groupingRibbonPageGroup1.ItemLinks.Add(this.commandBarSubItem3);
            this.groupingRibbonPageGroup1.ItemLinks.Add(this.commandBarItem6);
            this.groupingRibbonPageGroup1.ItemLinks.Add(this.commandBarItem7);
            this.groupingRibbonPageGroup1.ItemLinks.Add(this.commandBarSubItem4);
            this.groupingRibbonPageGroup1.Name = "groupingRibbonPageGroup1";
            // 
            // listToolsRibbonPage1
            // 
            this.listToolsRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.listHeaderAndFooterRibbonPageGroup1,
            this.listCommandsRibbonPageGroup1,
            this.listEditorRowLimitRibbonPageGroup1});
            this.listToolsRibbonPage1.Name = "listToolsRibbonPage1";
            // 
            // listHeaderAndFooterRibbonPageGroup1
            // 
            this.listHeaderAndFooterRibbonPageGroup1.ItemLinks.Add(this.commandBarSubItem5);
            this.listHeaderAndFooterRibbonPageGroup1.ItemLinks.Add(this.commandBarSubItem6);
            this.listHeaderAndFooterRibbonPageGroup1.Name = "listHeaderAndFooterRibbonPageGroup1";
            // 
            // listCommandsRibbonPageGroup1
            // 
            this.listCommandsRibbonPageGroup1.ItemLinks.Add(this.commandBarItem8);
            this.listCommandsRibbonPageGroup1.ItemLinks.Add(this.commandBarItem9);
            this.listCommandsRibbonPageGroup1.ItemLinks.Add(this.commandBarSubItem7);
            this.listCommandsRibbonPageGroup1.ItemLinks.Add(this.commandBarItem10);
            this.listCommandsRibbonPageGroup1.Name = "listCommandsRibbonPageGroup1";
            // 
            // listEditorRowLimitRibbonPageGroup1
            // 
            this.listEditorRowLimitRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup8);
            this.listEditorRowLimitRibbonPageGroup1.Name = "listEditorRowLimitRibbonPageGroup1";
            // 
            // chartRibbonPageCategory1
            // 
            this.chartRibbonPageCategory1.Control = null;
            this.chartRibbonPageCategory1.Name = "chartRibbonPageCategory1";
            this.chartRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.createChartRibbonPage1});
            this.chartRibbonPageCategory1.Visible = false;
            // 
            // createChartRibbonPage1
            // 
            this.createChartRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.chartTypeRibbonPageGroup1,
            this.chartAppearanceRibbonPageGroup1,
            this.chartWizardRibbonPageGroup1});
            this.createChartRibbonPage1.Name = "createChartRibbonPage1";
            this.createChartRibbonPage1.Visible = false;
            // 
            // chartTypeRibbonPageGroup1
            // 
            this.chartTypeRibbonPageGroup1.ItemLinks.Add(this.createBarBaseItem1);
            this.chartTypeRibbonPageGroup1.ItemLinks.Add(this.createLineBaseItem1);
            this.chartTypeRibbonPageGroup1.ItemLinks.Add(this.createPieBaseItem1);
            this.chartTypeRibbonPageGroup1.ItemLinks.Add(this.createRotatedBarBaseItem1);
            this.chartTypeRibbonPageGroup1.ItemLinks.Add(this.createAreaBaseItem1);
            this.chartTypeRibbonPageGroup1.ItemLinks.Add(this.createOtherSeriesTypesBaseItem1);
            this.chartTypeRibbonPageGroup1.Name = "chartTypeRibbonPageGroup1";
            // 
            // chartAppearanceRibbonPageGroup1
            // 
            this.chartAppearanceRibbonPageGroup1.ItemLinks.Add(this.changePaletteGalleryBaseItem1);
            this.chartAppearanceRibbonPageGroup1.ItemLinks.Add(this.changeAppearanceGalleryBaseItem1);
            this.chartAppearanceRibbonPageGroup1.Name = "chartAppearanceRibbonPageGroup1";
            // 
            // chartWizardRibbonPageGroup1
            // 
            this.chartWizardRibbonPageGroup1.AllowMinimize = false;
            this.chartWizardRibbonPageGroup1.ItemLinks.Add(this.runWizardChartItem1);
            this.chartWizardRibbonPageGroup1.Name = "chartWizardRibbonPageGroup1";
            // 
            // fileRibbonPage1
            // 
            this.fileRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.commonRibbonPageGroup1,
            this.dataRibbonPageGroup1});
            this.fileRibbonPage1.Name = "fileRibbonPage1";
            // 
            // commonRibbonPageGroup1
            // 
            this.commonRibbonPageGroup1.ItemLinks.Add(this.fileNewItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.fileOpenItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.fileSaveItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.fileSaveAsItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.commandBarItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.quickPrintItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.printItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.printPreviewItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.undoItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.redoItem1);
            this.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1";
            // 
            // dataRibbonPageGroup1
            // 
            this.dataRibbonPageGroup1.ItemLinks.Add(this.commandBarItem2);
            this.dataRibbonPageGroup1.Name = "dataRibbonPageGroup1";
            // 
            // homeRibbonPage1
            // 
            this.homeRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.clipboardRibbonPageGroup1,
            this.fontRibbonPageGroup1,
            this.paragraphRibbonPageGroup1,
            this.stylesRibbonPageGroup1,
            this.editingRibbonPageGroup1});
            this.homeRibbonPage1.Name = "homeRibbonPage1";
            reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable;
            reduceOperation1.Group = this.stylesRibbonPageGroup1;
            reduceOperation1.ItemLinkIndex = 0;
            reduceOperation1.ItemLinksCount = 0;
            reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery;
            this.homeRibbonPage1.ReduceOperations.Add(reduceOperation1);
            // 
            // clipboardRibbonPageGroup1
            // 
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.pasteItem1);
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.cutItem1);
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.copyItem1);
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.pasteSpecialItem1);
            this.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1";
            // 
            // fontRibbonPageGroup1
            // 
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup1);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup2);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup3);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.changeTextCaseItem1);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.clearFormattingItem1);
            this.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1";
            // 
            // paragraphRibbonPageGroup1
            // 
            this.paragraphRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup4);
            this.paragraphRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup5);
            this.paragraphRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup6);
            this.paragraphRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup7);
            this.paragraphRibbonPageGroup1.Name = "paragraphRibbonPageGroup1";
            // 
            // editingRibbonPageGroup1
            // 
            this.editingRibbonPageGroup1.ItemLinks.Add(this.findItem1);
            this.editingRibbonPageGroup1.ItemLinks.Add(this.replaceItem1);
            this.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1";
            // 
            // insertRibbonPage1
            // 
            this.insertRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pagesRibbonPageGroup1,
            this.tablesRibbonPageGroup1,
            this.illustrationsRibbonPageGroup1,
            this.toolboxRibbonPageGroup1,
            this.linksRibbonPageGroup1,
            this.headerFooterRibbonPageGroup1,
            this.textRibbonPageGroup1,
            this.symbolsRibbonPageGroup1});
            this.insertRibbonPage1.Name = "insertRibbonPage1";
            // 
            // pagesRibbonPageGroup1
            // 
            this.pagesRibbonPageGroup1.ItemLinks.Add(this.insertPageBreakItem1);
            this.pagesRibbonPageGroup1.Name = "pagesRibbonPageGroup1";
            // 
            // tablesRibbonPageGroup1
            // 
            this.tablesRibbonPageGroup1.ItemLinks.Add(this.insertTableItem1);
            this.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1";
            // 
            // illustrationsRibbonPageGroup1
            // 
            this.illustrationsRibbonPageGroup1.ItemLinks.Add(this.insertPictureItem1);
            this.illustrationsRibbonPageGroup1.ItemLinks.Add(this.insertFloatingPictureItem1);
            this.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1";
            // 
            // toolboxRibbonPageGroup1
            // 
            this.toolboxRibbonPageGroup1.ItemLinks.Add(this.commandBarItem3);
            this.toolboxRibbonPageGroup1.ItemLinks.Add(this.commandBarItem4);
            this.toolboxRibbonPageGroup1.ItemLinks.Add(this.commandBarItem5);
            this.toolboxRibbonPageGroup1.Name = "toolboxRibbonPageGroup1";
            // 
            // linksRibbonPageGroup1
            // 
            this.linksRibbonPageGroup1.ItemLinks.Add(this.insertBookmarkItem1);
            this.linksRibbonPageGroup1.ItemLinks.Add(this.insertHyperlinkItem1);
            this.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1";
            // 
            // headerFooterRibbonPageGroup1
            // 
            this.headerFooterRibbonPageGroup1.ItemLinks.Add(this.editPageHeaderItem1);
            this.headerFooterRibbonPageGroup1.ItemLinks.Add(this.editPageFooterItem1);
            this.headerFooterRibbonPageGroup1.ItemLinks.Add(this.insertPageNumberItem1);
            this.headerFooterRibbonPageGroup1.ItemLinks.Add(this.insertPageCountItem1);
            this.headerFooterRibbonPageGroup1.Name = "headerFooterRibbonPageGroup1";
            // 
            // textRibbonPageGroup1
            // 
            this.textRibbonPageGroup1.ItemLinks.Add(this.insertTextBoxItem1);
            this.textRibbonPageGroup1.Name = "textRibbonPageGroup1";
            // 
            // symbolsRibbonPageGroup1
            // 
            this.symbolsRibbonPageGroup1.ItemLinks.Add(this.insertSymbolItem1);
            this.symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1";
            // 
            // pageLayoutRibbonPage1
            // 
            this.pageLayoutRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pageSetupRibbonPageGroup1,
            this.pageBackgroundRibbonPageGroup1});
            this.pageLayoutRibbonPage1.Name = "pageLayoutRibbonPage1";
            // 
            // pageSetupRibbonPageGroup1
            // 
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.changeSectionPageMarginsItem1);
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.changeSectionPageOrientationItem1);
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.changeSectionPaperKindItem1);
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.changeSectionColumnsItem1);
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.insertBreakItem1);
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.changeSectionLineNumberingItem1);
            this.pageSetupRibbonPageGroup1.Name = "pageSetupRibbonPageGroup1";
            // 
            // pageBackgroundRibbonPageGroup1
            // 
            this.pageBackgroundRibbonPageGroup1.ItemLinks.Add(this.changePageColorItem1);
            this.pageBackgroundRibbonPageGroup1.Name = "pageBackgroundRibbonPageGroup1";
            // 
            // viewRibbonPage1
            // 
            this.viewRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.documentViewsRibbonPageGroup1,
            this.showRibbonPageGroup1,
            this.zoomRibbonPageGroup1,
            this.viewRibbonPageGroup1,
            this.mailMergeRibbonPageGroup1});
            this.viewRibbonPage1.Name = "viewRibbonPage1";
            // 
            // documentViewsRibbonPageGroup1
            // 
            this.documentViewsRibbonPageGroup1.ItemLinks.Add(this.switchToSimpleViewItem1);
            this.documentViewsRibbonPageGroup1.ItemLinks.Add(this.switchToDraftViewItem1);
            this.documentViewsRibbonPageGroup1.ItemLinks.Add(this.switchToPrintLayoutViewItem1);
            this.documentViewsRibbonPageGroup1.Name = "documentViewsRibbonPageGroup1";
            // 
            // showRibbonPageGroup1
            // 
            this.showRibbonPageGroup1.ItemLinks.Add(this.toggleShowHorizontalRulerItem1);
            this.showRibbonPageGroup1.ItemLinks.Add(this.toggleShowVerticalRulerItem1);
            this.showRibbonPageGroup1.Name = "showRibbonPageGroup1";
            // 
            // zoomRibbonPageGroup1
            // 
            this.zoomRibbonPageGroup1.ItemLinks.Add(this.zoomOutItem1);
            this.zoomRibbonPageGroup1.ItemLinks.Add(this.zoomInItem1);
            this.zoomRibbonPageGroup1.Name = "zoomRibbonPageGroup1";
            // 
            // viewRibbonPageGroup1
            // 
            this.viewRibbonPageGroup1.ItemLinks.Add(this.snapBarToolbarsListItem1);
            this.viewRibbonPageGroup1.ItemLinks.Add(this.commandBarCheckItem1);
            this.viewRibbonPageGroup1.Name = "viewRibbonPageGroup1";
            // 
            // mailMergeRibbonPageGroup1
            // 
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.showAllFieldCodesItem1);
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.showAllFieldResultsItem1);
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.toggleFieldHighlightingItem1);
            this.mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1";
            // 
            // reviewRibbonPage1
            // 
            this.reviewRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.documentProofingRibbonPageGroup1});
            this.reviewRibbonPage1.Name = "reviewRibbonPage1";
            // 
            // documentProofingRibbonPageGroup1
            // 
            this.documentProofingRibbonPageGroup1.ItemLinks.Add(this.checkSpellingItem1);
            this.documentProofingRibbonPageGroup1.Name = "documentProofingRibbonPageGroup1";
            // 
            // referencesRibbonPage1
            // 
            this.referencesRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.tableOfContentsRibbonPageGroup1,
            this.captionsRibbonPageGroup1});
            this.referencesRibbonPage1.Name = "referencesRibbonPage1";
            // 
            // tableOfContentsRibbonPageGroup1
            // 
            this.tableOfContentsRibbonPageGroup1.ItemLinks.Add(this.insertTableOfContentsItem1);
            this.tableOfContentsRibbonPageGroup1.ItemLinks.Add(this.updateTableOfContentsItem1);
            this.tableOfContentsRibbonPageGroup1.ItemLinks.Add(this.addParagraphsToTableOfContentItem1);
            this.tableOfContentsRibbonPageGroup1.Name = "tableOfContentsRibbonPageGroup1";
            // 
            // captionsRibbonPageGroup1
            // 
            this.captionsRibbonPageGroup1.ItemLinks.Add(this.insertCaptionPlaceholderItem1);
            this.captionsRibbonPageGroup1.ItemLinks.Add(this.insertTableOfFiguresPlaceholderItem1);
            this.captionsRibbonPageGroup1.ItemLinks.Add(this.updateTableOfFiguresItem1);
            this.captionsRibbonPageGroup1.Name = "captionsRibbonPageGroup1";
            // 
            // snapDockManager1
            // 
            this.snapDockManager1.Form = this;
            this.snapDockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1});
            this.snapDockManager1.SnapControl = this.snapControl1;
            this.snapDockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // panelContainer1
            // 
            this.panelContainer1.Controls.Add(this.fieldListDockPanel1);
            this.panelContainer1.Controls.Add(this.reportExplorerDockPanel1);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.panelContainer1.ID = new System.Guid("b3eb4015-99a0-4ff6-a528-50120ef0dbbb");
            this.panelContainer1.Location = new System.Drawing.Point(885, 142);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(200, 200);
            this.panelContainer1.Size = new System.Drawing.Size(200, 405);
            this.panelContainer1.Text = "panelContainer1";
            // 
            // fieldListDockPanel1
            // 
            this.fieldListDockPanel1.Controls.Add(this.fieldListDockPanel1_Container);
            this.fieldListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.fieldListDockPanel1.ID = new System.Guid("cd943dd0-8fdd-4717-98b1-c06411c7445e");
            this.fieldListDockPanel1.Location = new System.Drawing.Point(0, 0);
            this.fieldListDockPanel1.Name = "fieldListDockPanel1";
            this.fieldListDockPanel1.OriginalSize = new System.Drawing.Size(200, 262);
            this.fieldListDockPanel1.Size = new System.Drawing.Size(200, 212);
            this.fieldListDockPanel1.SnapControl = this.snapControl1;
            // 
            // fieldListDockPanel1_Container
            // 
            this.fieldListDockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container";
            this.fieldListDockPanel1_Container.Size = new System.Drawing.Size(192, 185);
            this.fieldListDockPanel1_Container.TabIndex = 0;
            // 
            // reportExplorerDockPanel1
            // 
            this.reportExplorerDockPanel1.Controls.Add(this.reportExplorerDockPanel1_Container);
            this.reportExplorerDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.reportExplorerDockPanel1.ID = new System.Guid("17731631-17d9-4478-b503-5e83bf7acb00");
            this.reportExplorerDockPanel1.Location = new System.Drawing.Point(0, 212);
            this.reportExplorerDockPanel1.Name = "reportExplorerDockPanel1";
            this.reportExplorerDockPanel1.OriginalSize = new System.Drawing.Size(200, 263);
            this.reportExplorerDockPanel1.Size = new System.Drawing.Size(200, 193);
            this.reportExplorerDockPanel1.SnapControl = this.snapControl1;
            // 
            // reportExplorerDockPanel1_Container
            // 
            this.reportExplorerDockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.reportExplorerDockPanel1_Container.Name = "reportExplorerDockPanel1_Container";
            this.reportExplorerDockPanel1_Container.Size = new System.Drawing.Size(192, 166);
            this.reportExplorerDockPanel1_Container.TabIndex = 0;
            // 
            // snapDocumentManager1
            // 
            this.snapDocumentManager1.ClientControl = this.snapControl1;
            this.snapDocumentManager1.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False;
            this.snapDocumentManager1.View = this.noDocumentsView1;
            this.snapDocumentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.noDocumentsView1});
            // 
            // snapBarController1
            // 
            this.snapBarController1.BarItems.Add(this.fileNewItem1);
            this.snapBarController1.BarItems.Add(this.fileOpenItem1);
            this.snapBarController1.BarItems.Add(this.fileSaveItem1);
            this.snapBarController1.BarItems.Add(this.fileSaveAsItem1);
            this.snapBarController1.BarItems.Add(this.commandBarItem1);
            this.snapBarController1.BarItems.Add(this.quickPrintItem1);
            this.snapBarController1.BarItems.Add(this.printItem1);
            this.snapBarController1.BarItems.Add(this.printPreviewItem1);
            this.snapBarController1.BarItems.Add(this.undoItem1);
            this.snapBarController1.BarItems.Add(this.redoItem1);
            this.snapBarController1.BarItems.Add(this.commandBarItem2);
            this.snapBarController1.BarItems.Add(this.pasteItem1);
            this.snapBarController1.BarItems.Add(this.cutItem1);
            this.snapBarController1.BarItems.Add(this.copyItem1);
            this.snapBarController1.BarItems.Add(this.pasteSpecialItem1);
            this.snapBarController1.BarItems.Add(this.changeFontNameItem1);
            this.snapBarController1.BarItems.Add(this.changeFontSizeItem1);
            this.snapBarController1.BarItems.Add(this.fontSizeIncreaseItem1);
            this.snapBarController1.BarItems.Add(this.fontSizeDecreaseItem1);
            this.snapBarController1.BarItems.Add(this.toggleFontBoldItem1);
            this.snapBarController1.BarItems.Add(this.toggleFontItalicItem1);
            this.snapBarController1.BarItems.Add(this.toggleFontUnderlineItem1);
            this.snapBarController1.BarItems.Add(this.toggleFontDoubleUnderlineItem1);
            this.snapBarController1.BarItems.Add(this.toggleFontStrikeoutItem1);
            this.snapBarController1.BarItems.Add(this.toggleFontDoubleStrikeoutItem1);
            this.snapBarController1.BarItems.Add(this.toggleFontSuperscriptItem1);
            this.snapBarController1.BarItems.Add(this.toggleFontSubscriptItem1);
            this.snapBarController1.BarItems.Add(this.changeFontColorItem1);
            this.snapBarController1.BarItems.Add(this.changeFontBackColorItem1);
            this.snapBarController1.BarItems.Add(this.changeTextCaseItem1);
            this.snapBarController1.BarItems.Add(this.makeTextUpperCaseItem1);
            this.snapBarController1.BarItems.Add(this.makeTextLowerCaseItem1);
            this.snapBarController1.BarItems.Add(this.toggleTextCaseItem1);
            this.snapBarController1.BarItems.Add(this.clearFormattingItem1);
            this.snapBarController1.BarItems.Add(this.toggleBulletedListItem1);
            this.snapBarController1.BarItems.Add(this.toggleNumberingListItem1);
            this.snapBarController1.BarItems.Add(this.toggleMultiLevelListItem1);
            this.snapBarController1.BarItems.Add(this.decreaseIndentItem1);
            this.snapBarController1.BarItems.Add(this.increaseIndentItem1);
            this.snapBarController1.BarItems.Add(this.toggleParagraphAlignmentLeftItem1);
            this.snapBarController1.BarItems.Add(this.toggleParagraphAlignmentCenterItem1);
            this.snapBarController1.BarItems.Add(this.toggleParagraphAlignmentRightItem1);
            this.snapBarController1.BarItems.Add(this.toggleParagraphAlignmentJustifyItem1);
            this.snapBarController1.BarItems.Add(this.toggleShowWhitespaceItem1);
            this.snapBarController1.BarItems.Add(this.changeParagraphLineSpacingItem1);
            this.snapBarController1.BarItems.Add(this.setSingleParagraphSpacingItem1);
            this.snapBarController1.BarItems.Add(this.setSesquialteralParagraphSpacingItem1);
            this.snapBarController1.BarItems.Add(this.setDoubleParagraphSpacingItem1);
            this.snapBarController1.BarItems.Add(this.showLineSpacingFormItem1);
            this.snapBarController1.BarItems.Add(this.addSpacingBeforeParagraphItem1);
            this.snapBarController1.BarItems.Add(this.removeSpacingBeforeParagraphItem1);
            this.snapBarController1.BarItems.Add(this.addSpacingAfterParagraphItem1);
            this.snapBarController1.BarItems.Add(this.removeSpacingAfterParagraphItem1);
            this.snapBarController1.BarItems.Add(this.changeParagraphBackColorItem1);
            this.snapBarController1.BarItems.Add(this.galleryChangeStyleItem1);
            this.snapBarController1.BarItems.Add(this.findItem1);
            this.snapBarController1.BarItems.Add(this.replaceItem1);
            this.snapBarController1.BarItems.Add(this.insertPageBreakItem1);
            this.snapBarController1.BarItems.Add(this.insertTableItem1);
            this.snapBarController1.BarItems.Add(this.insertPictureItem1);
            this.snapBarController1.BarItems.Add(this.insertFloatingPictureItem1);
            this.snapBarController1.BarItems.Add(this.commandBarItem3);
            this.snapBarController1.BarItems.Add(this.commandBarItem4);
            this.snapBarController1.BarItems.Add(this.commandBarItem5);
            this.snapBarController1.BarItems.Add(this.insertBookmarkItem1);
            this.snapBarController1.BarItems.Add(this.insertHyperlinkItem1);
            this.snapBarController1.BarItems.Add(this.editPageHeaderItem1);
            this.snapBarController1.BarItems.Add(this.editPageFooterItem1);
            this.snapBarController1.BarItems.Add(this.insertPageNumberItem1);
            this.snapBarController1.BarItems.Add(this.insertPageCountItem1);
            this.snapBarController1.BarItems.Add(this.insertTextBoxItem1);
            this.snapBarController1.BarItems.Add(this.insertSymbolItem1);
            this.snapBarController1.BarItems.Add(this.changeSectionPageMarginsItem1);
            this.snapBarController1.BarItems.Add(this.setNormalSectionPageMarginsItem1);
            this.snapBarController1.BarItems.Add(this.setNarrowSectionPageMarginsItem1);
            this.snapBarController1.BarItems.Add(this.setModerateSectionPageMarginsItem1);
            this.snapBarController1.BarItems.Add(this.setWideSectionPageMarginsItem1);
            this.snapBarController1.BarItems.Add(this.showPageMarginsSetupFormItem1);
            this.snapBarController1.BarItems.Add(this.changeSectionPageOrientationItem1);
            this.snapBarController1.BarItems.Add(this.setPortraitPageOrientationItem1);
            this.snapBarController1.BarItems.Add(this.setLandscapePageOrientationItem1);
            this.snapBarController1.BarItems.Add(this.changeSectionPaperKindItem1);
            this.snapBarController1.BarItems.Add(this.changeSectionColumnsItem1);
            this.snapBarController1.BarItems.Add(this.setSectionOneColumnItem1);
            this.snapBarController1.BarItems.Add(this.setSectionTwoColumnsItem1);
            this.snapBarController1.BarItems.Add(this.setSectionThreeColumnsItem1);
            this.snapBarController1.BarItems.Add(this.showColumnsSetupFormItem1);
            this.snapBarController1.BarItems.Add(this.insertBreakItem1);
            this.snapBarController1.BarItems.Add(this.insertPageBreakItem2);
            this.snapBarController1.BarItems.Add(this.insertColumnBreakItem1);
            this.snapBarController1.BarItems.Add(this.insertSectionBreakNextPageItem1);
            this.snapBarController1.BarItems.Add(this.insertSectionBreakEvenPageItem1);
            this.snapBarController1.BarItems.Add(this.insertSectionBreakOddPageItem1);
            this.snapBarController1.BarItems.Add(this.changeSectionLineNumberingItem1);
            this.snapBarController1.BarItems.Add(this.setSectionLineNumberingNoneItem1);
            this.snapBarController1.BarItems.Add(this.setSectionLineNumberingContinuousItem1);
            this.snapBarController1.BarItems.Add(this.setSectionLineNumberingRestartNewPageItem1);
            this.snapBarController1.BarItems.Add(this.setSectionLineNumberingRestartNewSectionItem1);
            this.snapBarController1.BarItems.Add(this.toggleParagraphSuppressLineNumbersItem1);
            this.snapBarController1.BarItems.Add(this.showLineNumberingFormItem1);
            this.snapBarController1.BarItems.Add(this.changePageColorItem1);
            this.snapBarController1.BarItems.Add(this.switchToSimpleViewItem1);
            this.snapBarController1.BarItems.Add(this.switchToDraftViewItem1);
            this.snapBarController1.BarItems.Add(this.switchToPrintLayoutViewItem1);
            this.snapBarController1.BarItems.Add(this.toggleShowHorizontalRulerItem1);
            this.snapBarController1.BarItems.Add(this.toggleShowVerticalRulerItem1);
            this.snapBarController1.BarItems.Add(this.zoomOutItem1);
            this.snapBarController1.BarItems.Add(this.zoomInItem1);
            this.snapBarController1.BarItems.Add(this.snapBarToolbarsListItem1);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem1);
            this.snapBarController1.BarItems.Add(this.showAllFieldCodesItem1);
            this.snapBarController1.BarItems.Add(this.showAllFieldResultsItem1);
            this.snapBarController1.BarItems.Add(this.toggleFieldHighlightingItem1);
            this.snapBarController1.BarItems.Add(this.goToPageHeaderItem1);
            this.snapBarController1.BarItems.Add(this.goToPageFooterItem1);
            this.snapBarController1.BarItems.Add(this.goToNextHeaderFooterItem1);
            this.snapBarController1.BarItems.Add(this.goToPreviousHeaderFooterItem1);
            this.snapBarController1.BarItems.Add(this.toggleLinkToPreviousItem1);
            this.snapBarController1.BarItems.Add(this.toggleDifferentFirstPageItem1);
            this.snapBarController1.BarItems.Add(this.toggleDifferentOddAndEvenPagesItem1);
            this.snapBarController1.BarItems.Add(this.closePageHeaderFooterItem1);
            this.snapBarController1.BarItems.Add(this.toggleFirstRowItem1);
            this.snapBarController1.BarItems.Add(this.toggleLastRowItem1);
            this.snapBarController1.BarItems.Add(this.toggleBandedRowsItem1);
            this.snapBarController1.BarItems.Add(this.toggleFirstColumnItem1);
            this.snapBarController1.BarItems.Add(this.toggleLastColumnItem1);
            this.snapBarController1.BarItems.Add(this.toggleBandedColumnsItem1);
            this.snapBarController1.BarItems.Add(this.galleryChangeTableStyleItem1);
            this.snapBarController1.BarItems.Add(this.galleryChangeTableCellStyleItem1);
            this.snapBarController1.BarItems.Add(this.changeTableBorderLineStyleItem1);
            this.snapBarController1.BarItems.Add(this.changeTableBorderLineWeightItem1);
            this.snapBarController1.BarItems.Add(this.changeTableBorderColorItem1);
            this.snapBarController1.BarItems.Add(this.changeTableBordersItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsBottomBorderItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsTopBorderItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsLeftBorderItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsRightBorderItem1);
            this.snapBarController1.BarItems.Add(this.resetTableCellsAllBordersItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsAllBordersItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsOutsideBorderItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsInsideBorderItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsInsideHorizontalBorderItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsInsideVerticalBorderItem1);
            this.snapBarController1.BarItems.Add(this.toggleShowTableGridLinesItem1);
            this.snapBarController1.BarItems.Add(this.changeTableCellsShadingItem1);
            this.snapBarController1.BarItems.Add(this.selectTableElementsItem1);
            this.snapBarController1.BarItems.Add(this.selectTableCellItem1);
            this.snapBarController1.BarItems.Add(this.selectTableColumnItem1);
            this.snapBarController1.BarItems.Add(this.selectTableRowItem1);
            this.snapBarController1.BarItems.Add(this.selectTableItem1);
            this.snapBarController1.BarItems.Add(this.showTablePropertiesFormItem1);
            this.snapBarController1.BarItems.Add(this.deleteTableElementsItem1);
            this.snapBarController1.BarItems.Add(this.showDeleteTableCellsFormItem1);
            this.snapBarController1.BarItems.Add(this.deleteTableColumnsItem1);
            this.snapBarController1.BarItems.Add(this.deleteTableRowsItem1);
            this.snapBarController1.BarItems.Add(this.deleteTableItem1);
            this.snapBarController1.BarItems.Add(this.insertTableRowAboveItem1);
            this.snapBarController1.BarItems.Add(this.insertTableRowBelowItem1);
            this.snapBarController1.BarItems.Add(this.insertTableColumnToLeftItem1);
            this.snapBarController1.BarItems.Add(this.insertTableColumnToRightItem1);
            this.snapBarController1.BarItems.Add(this.mergeTableCellsItem1);
            this.snapBarController1.BarItems.Add(this.showSplitTableCellsForm1);
            this.snapBarController1.BarItems.Add(this.splitTableItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableAutoFitItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableAutoFitContentsItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableAutoFitWindowItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableFixedColumnWidthItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsTopLeftAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsMiddleLeftAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsBottomLeftAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsTopCenterAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsMiddleCenterAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsBottomCenterAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsTopRightAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsMiddleRightAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsBottomRightAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.showTableOptionsFormItem1);
            this.snapBarController1.BarItems.Add(this.checkSpellingItem1);
            this.snapBarController1.BarItems.Add(this.insertTableOfContentsItem1);
            this.snapBarController1.BarItems.Add(this.updateTableOfContentsItem1);
            this.snapBarController1.BarItems.Add(this.addParagraphsToTableOfContentItem1);
            this.snapBarController1.BarItems.Add(this.setParagraphHeadingLevelItem1);
            this.snapBarController1.BarItems.Add(this.setParagraphHeadingLevelItem2);
            this.snapBarController1.BarItems.Add(this.setParagraphHeadingLevelItem3);
            this.snapBarController1.BarItems.Add(this.setParagraphHeadingLevelItem4);
            this.snapBarController1.BarItems.Add(this.setParagraphHeadingLevelItem5);
            this.snapBarController1.BarItems.Add(this.setParagraphHeadingLevelItem6);
            this.snapBarController1.BarItems.Add(this.setParagraphHeadingLevelItem7);
            this.snapBarController1.BarItems.Add(this.setParagraphHeadingLevelItem8);
            this.snapBarController1.BarItems.Add(this.setParagraphHeadingLevelItem9);
            this.snapBarController1.BarItems.Add(this.setParagraphHeadingLevelItem10);
            this.snapBarController1.BarItems.Add(this.insertCaptionPlaceholderItem1);
            this.snapBarController1.BarItems.Add(this.insertFiguresCaptionItems1);
            this.snapBarController1.BarItems.Add(this.insertTablesCaptionItems1);
            this.snapBarController1.BarItems.Add(this.insertEquationsCaptionItems1);
            this.snapBarController1.BarItems.Add(this.insertTableOfFiguresPlaceholderItem1);
            this.snapBarController1.BarItems.Add(this.insertTableOfFiguresItems1);
            this.snapBarController1.BarItems.Add(this.insertTableOfTablesItems1);
            this.snapBarController1.BarItems.Add(this.insertTableOfEquationsItems1);
            this.snapBarController1.BarItems.Add(this.updateTableOfFiguresItem1);
            this.snapBarController1.BarItems.Add(this.changeFloatingObjectFillColorItem1);
            this.snapBarController1.BarItems.Add(this.changeFloatingObjectOutlineColorItem1);
            this.snapBarController1.BarItems.Add(this.changeFloatingObjectOutlineWeightItem1);
            this.snapBarController1.BarItems.Add(this.changeFloatingObjectTextWrapTypeItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectSquareTextWrapTypeItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectTightTextWrapTypeItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectThroughTextWrapTypeItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectTopAndBottomTextWrapTypeItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectBehindTextWrapTypeItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectInFrontOfTextWrapTypeItem1);
            this.snapBarController1.BarItems.Add(this.changeFloatingObjectAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectTopLeftAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectTopCenterAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectTopRightAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectMiddleLeftAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectMiddleCenterAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectMiddleRightAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectBottomLeftAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectBottomCenterAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectBottomRightAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.floatingObjectBringForwardSubItem1);
            this.snapBarController1.BarItems.Add(this.floatingObjectBringForwardItem1);
            this.snapBarController1.BarItems.Add(this.floatingObjectBringToFrontItem1);
            this.snapBarController1.BarItems.Add(this.floatingObjectBringInFrontOfTextItem1);
            this.snapBarController1.BarItems.Add(this.floatingObjectSendBackwardSubItem1);
            this.snapBarController1.BarItems.Add(this.floatingObjectSendBackwardItem1);
            this.snapBarController1.BarItems.Add(this.floatingObjectSendToBackItem1);
            this.snapBarController1.BarItems.Add(this.floatingObjectSendBehindTextItem1);
            this.snapBarController1.BarItems.Add(this.themesGalleryBarItem1);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem2);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem3);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem4);
            this.snapBarController1.BarItems.Add(this.commandBarSubItem1);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem5);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem6);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem7);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem8);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem9);
            this.snapBarController1.BarItems.Add(this.filterPopupButtonItem1);
            this.snapBarController1.BarItems.Add(this.propertiesBarButtonItem1);
            this.snapBarController1.BarItems.Add(this.commandBarSubItem2);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem10);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem11);
            this.snapBarController1.BarItems.Add(this.commandBarSubItem3);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem12);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem13);
            this.snapBarController1.BarItems.Add(this.commandBarItem6);
            this.snapBarController1.BarItems.Add(this.commandBarItem7);
            this.snapBarController1.BarItems.Add(this.commandBarSubItem4);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem14);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem15);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem16);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem17);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem18);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem19);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem20);
            this.snapBarController1.BarItems.Add(this.commandBarSubItem5);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem21);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem22);
            this.snapBarController1.BarItems.Add(this.commandBarSubItem6);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem23);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem24);
            this.snapBarController1.BarItems.Add(this.commandBarItem8);
            this.snapBarController1.BarItems.Add(this.commandBarItem9);
            this.snapBarController1.BarItems.Add(this.commandBarSubItem7);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem25);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem26);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem27);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem28);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem29);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem30);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem31);
            this.snapBarController1.BarItems.Add(this.commandBarItem10);
            this.snapBarController1.BarItems.Add(this.changeEditorRowLimitItem1);
            this.snapBarController1.BarItems.Add(this.createBarBaseItem1);
            this.snapBarController1.BarItems.Add(this.createLineBaseItem1);
            this.snapBarController1.BarItems.Add(this.createPieBaseItem1);
            this.snapBarController1.BarItems.Add(this.createRotatedBarBaseItem1);
            this.snapBarController1.BarItems.Add(this.createAreaBaseItem1);
            this.snapBarController1.BarItems.Add(this.createOtherSeriesTypesBaseItem1);
            this.snapBarController1.BarItems.Add(this.changePaletteGalleryBaseItem1);
            this.snapBarController1.BarItems.Add(this.changeAppearanceGalleryBaseItem1);
            this.snapBarController1.BarItems.Add(this.runWizardChartItem1);
            this.snapBarController1.ContextPageCategories.Add(new DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(this.headerFooterToolsRibbonPageCategory1));
            this.snapBarController1.ContextPageCategories.Add(new DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(this.tableToolsRibbonPageCategory1));
            this.snapBarController1.ContextPageCategories.Add(new DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(this.floatingPictureToolsRibbonPageCategory1));
            this.snapBarController1.ContextPageCategories.Add(new DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(this.dataToolsRibbonPageCategory1));
            this.snapBarController1.ContextPageCategories.Add(new DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(this.chartRibbonPageCategory1));
            this.snapBarController1.Control = this.snapControl1;
            this.snapBarController1.RibbonControl = this.ribbonControl1;
            this.snapBarController1.SnapDockManager = this.snapDockManager1;
            // 
            // insertPageBreakItem2
            // 
            this.insertPageBreakItem2.Id = -1;
            this.insertPageBreakItem2.Name = "insertPageBreakItem2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 547);
            this.Controls.Add(this.snapControl1);
            this.Controls.Add(this.panelContainer1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBorderLineStyle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBorderLineWeight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFloatingObjectOutlineWeight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemEditorRowLimitEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapDockManager1)).EndInit();
            this.panelContainer1.ResumeLayout(false);
            this.fieldListDockPanel1.ResumeLayout(false);
            this.reportExplorerDockPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.snapDocumentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapBarController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Snap.SnapControl snapControl1;
        private DevExpress.Snap.Extensions.SnapDockManager snapDockManager1;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.Snap.Extensions.UI.FieldListDockPanel fieldListDockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer fieldListDockPanel1_Container;
        private DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel reportExplorerDockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer reportExplorerDockPanel1_Container;
        private DevExpress.Snap.Extensions.SnapDocumentManager snapDocumentManager1;
        private DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView noDocumentsView1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraRichEdit.UI.FileNewItem fileNewItem1;
        private DevExpress.XtraRichEdit.UI.FileOpenItem fileOpenItem1;
        private DevExpress.XtraRichEdit.UI.FileSaveItem fileSaveItem1;
        private DevExpress.XtraRichEdit.UI.FileSaveAsItem fileSaveAsItem1;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem1;
        private DevExpress.XtraRichEdit.UI.QuickPrintItem quickPrintItem1;
        private DevExpress.XtraRichEdit.UI.PrintItem printItem1;
        private DevExpress.XtraRichEdit.UI.PrintPreviewItem printPreviewItem1;
        private DevExpress.XtraRichEdit.UI.UndoItem undoItem1;
        private DevExpress.XtraRichEdit.UI.RedoItem redoItem1;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem2;
        private DevExpress.XtraRichEdit.UI.PasteItem pasteItem1;
        private DevExpress.XtraRichEdit.UI.CutItem cutItem1;
        private DevExpress.XtraRichEdit.UI.CopyItem copyItem1;
        private DevExpress.XtraRichEdit.UI.PasteSpecialItem pasteSpecialItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraRichEdit.UI.ChangeFontNameItem changeFontNameItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private DevExpress.XtraRichEdit.UI.ChangeFontSizeItem changeFontSizeItem1;
        private DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit repositoryItemRichEditFontSizeEdit1;
        private DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem fontSizeIncreaseItem1;
        private DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem fontSizeDecreaseItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup2;
        private DevExpress.XtraRichEdit.UI.ToggleFontBoldItem toggleFontBoldItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontItalicItem toggleFontItalicItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem toggleFontUnderlineItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem toggleFontDoubleUnderlineItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem toggleFontStrikeoutItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem toggleFontDoubleStrikeoutItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem toggleFontSuperscriptItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem toggleFontSubscriptItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup3;
        private DevExpress.XtraRichEdit.UI.ChangeFontColorItem changeFontColorItem1;
        private DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem changeFontBackColorItem1;
        private DevExpress.XtraRichEdit.UI.ChangeTextCaseItem changeTextCaseItem1;
        private DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem makeTextUpperCaseItem1;
        private DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem makeTextLowerCaseItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTextCaseItem toggleTextCaseItem1;
        private DevExpress.XtraRichEdit.UI.ClearFormattingItem clearFormattingItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup4;
        private DevExpress.XtraRichEdit.UI.ToggleBulletedListItem toggleBulletedListItem1;
        private DevExpress.XtraRichEdit.UI.ToggleNumberingListItem toggleNumberingListItem1;
        private DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem toggleMultiLevelListItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup5;
        private DevExpress.XtraRichEdit.UI.DecreaseIndentItem decreaseIndentItem1;
        private DevExpress.XtraRichEdit.UI.IncreaseIndentItem increaseIndentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem toggleShowWhitespaceItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup6;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem toggleParagraphAlignmentLeftItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem toggleParagraphAlignmentCenterItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem toggleParagraphAlignmentRightItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem toggleParagraphAlignmentJustifyItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup7;
        private DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem changeParagraphLineSpacingItem1;
        private DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem setSingleParagraphSpacingItem1;
        private DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem setSesquialteralParagraphSpacingItem1;
        private DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem setDoubleParagraphSpacingItem1;
        private DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem showLineSpacingFormItem1;
        private DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem addSpacingBeforeParagraphItem1;
        private DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem removeSpacingBeforeParagraphItem1;
        private DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem addSpacingAfterParagraphItem1;
        private DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem removeSpacingAfterParagraphItem1;
        private DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem changeParagraphBackColorItem1;
        private DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem galleryChangeStyleItem1;
        private DevExpress.XtraRichEdit.UI.FindItem findItem1;
        private DevExpress.XtraRichEdit.UI.ReplaceItem replaceItem1;
        private DevExpress.XtraRichEdit.UI.InsertPageBreakItem insertPageBreakItem1;
        private DevExpress.XtraRichEdit.UI.InsertTableItem insertTableItem1;
        private DevExpress.XtraRichEdit.UI.InsertPictureItem insertPictureItem1;
        private DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem insertFloatingPictureItem1;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem3;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem4;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem5;
        private DevExpress.XtraRichEdit.UI.InsertBookmarkItem insertBookmarkItem1;
        private DevExpress.XtraRichEdit.UI.InsertHyperlinkItem insertHyperlinkItem1;
        private DevExpress.XtraRichEdit.UI.EditPageHeaderItem editPageHeaderItem1;
        private DevExpress.XtraRichEdit.UI.EditPageFooterItem editPageFooterItem1;
        private DevExpress.XtraRichEdit.UI.InsertPageNumberItem insertPageNumberItem1;
        private DevExpress.XtraRichEdit.UI.InsertPageCountItem insertPageCountItem1;
        private DevExpress.XtraRichEdit.UI.InsertTextBoxItem insertTextBoxItem1;
        private DevExpress.XtraRichEdit.UI.InsertSymbolItem insertSymbolItem1;
        private DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem changeSectionPageMarginsItem1;
        private DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem setNormalSectionPageMarginsItem1;
        private DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem setNarrowSectionPageMarginsItem1;
        private DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem setModerateSectionPageMarginsItem1;
        private DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem setWideSectionPageMarginsItem1;
        private DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem showPageMarginsSetupFormItem1;
        private DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem changeSectionPageOrientationItem1;
        private DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem setPortraitPageOrientationItem1;
        private DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem setLandscapePageOrientationItem1;
        private DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem changeSectionPaperKindItem1;
        private DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem changeSectionColumnsItem1;
        private DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem setSectionOneColumnItem1;
        private DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem setSectionTwoColumnsItem1;
        private DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem setSectionThreeColumnsItem1;
        private DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem showColumnsSetupFormItem1;
        private DevExpress.XtraRichEdit.UI.InsertBreakItem insertBreakItem1;
        private DevExpress.XtraRichEdit.UI.InsertColumnBreakItem insertColumnBreakItem1;
        private DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem insertSectionBreakNextPageItem1;
        private DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem insertSectionBreakEvenPageItem1;
        private DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem insertSectionBreakOddPageItem1;
        private DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem changeSectionLineNumberingItem1;
        private DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem setSectionLineNumberingNoneItem1;
        private DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem setSectionLineNumberingContinuousItem1;
        private DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem setSectionLineNumberingRestartNewPageItem1;
        private DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem setSectionLineNumberingRestartNewSectionItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem toggleParagraphSuppressLineNumbersItem1;
        private DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem showLineNumberingFormItem1;
        private DevExpress.XtraRichEdit.UI.ChangePageColorItem changePageColorItem1;
        private DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem switchToSimpleViewItem1;
        private DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem switchToDraftViewItem1;
        private DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem switchToPrintLayoutViewItem1;
        private DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem toggleShowHorizontalRulerItem1;
        private DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem toggleShowVerticalRulerItem1;
        private DevExpress.XtraRichEdit.UI.ZoomOutItem zoomOutItem1;
        private DevExpress.XtraRichEdit.UI.ZoomInItem zoomInItem1;
        private DevExpress.Snap.Extensions.UI.SnapBarToolbarsListItem snapBarToolbarsListItem1;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem1;
        private DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem showAllFieldCodesItem1;
        private DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem showAllFieldResultsItem1;
        private DevExpress.Snap.Extensions.UI.ToggleFieldHighlightingItem toggleFieldHighlightingItem1;
        private DevExpress.XtraRichEdit.UI.GoToPageHeaderItem goToPageHeaderItem1;
        private DevExpress.XtraRichEdit.UI.GoToPageFooterItem goToPageFooterItem1;
        private DevExpress.XtraRichEdit.UI.GoToNextHeaderFooterItem goToNextHeaderFooterItem1;
        private DevExpress.XtraRichEdit.UI.GoToPreviousHeaderFooterItem goToPreviousHeaderFooterItem1;
        private DevExpress.XtraRichEdit.UI.ToggleLinkToPreviousItem toggleLinkToPreviousItem1;
        private DevExpress.XtraRichEdit.UI.ToggleDifferentFirstPageItem toggleDifferentFirstPageItem1;
        private DevExpress.XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem toggleDifferentOddAndEvenPagesItem1;
        private DevExpress.XtraRichEdit.UI.ClosePageHeaderFooterItem closePageHeaderFooterItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFirstRowItem toggleFirstRowItem1;
        private DevExpress.XtraRichEdit.UI.ToggleLastRowItem toggleLastRowItem1;
        private DevExpress.XtraRichEdit.UI.ToggleBandedRowsItem toggleBandedRowsItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFirstColumnItem toggleFirstColumnItem1;
        private DevExpress.XtraRichEdit.UI.ToggleLastColumnItem toggleLastColumnItem1;
        private DevExpress.XtraRichEdit.UI.ToggleBandedColumnsItem toggleBandedColumnsItem1;
        private DevExpress.XtraRichEdit.UI.GalleryChangeTableStyleItem galleryChangeTableStyleItem1;
        private DevExpress.Snap.Extensions.UI.GalleryChangeTableCellStyleItem galleryChangeTableCellStyleItem1;
        private DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem changeTableBorderLineStyleItem1;
        private DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle repositoryItemBorderLineStyle1;
        private DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem changeTableBorderLineWeightItem1;
        private DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight repositoryItemBorderLineWeight1;
        private DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem changeTableBorderColorItem1;
        private DevExpress.XtraRichEdit.UI.ChangeTableBordersItem changeTableBordersItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem toggleTableCellsBottomBorderItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem toggleTableCellsTopBorderItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem toggleTableCellsLeftBorderItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem toggleTableCellsRightBorderItem1;
        private DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem resetTableCellsAllBordersItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem toggleTableCellsAllBordersItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem toggleTableCellsOutsideBorderItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem toggleTableCellsInsideBorderItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem toggleTableCellsInsideHorizontalBorderItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem toggleTableCellsInsideVerticalBorderItem1;
        private DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem toggleShowTableGridLinesItem1;
        private DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem changeTableCellsShadingItem1;
        private DevExpress.XtraRichEdit.UI.SelectTableElementsItem selectTableElementsItem1;
        private DevExpress.XtraRichEdit.UI.SelectTableCellItem selectTableCellItem1;
        private DevExpress.XtraRichEdit.UI.SelectTableColumnItem selectTableColumnItem1;
        private DevExpress.XtraRichEdit.UI.SelectTableRowItem selectTableRowItem1;
        private DevExpress.XtraRichEdit.UI.SelectTableItem selectTableItem1;
        private DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem showTablePropertiesFormItem1;
        private DevExpress.XtraRichEdit.UI.DeleteTableElementsItem deleteTableElementsItem1;
        private DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem showDeleteTableCellsFormItem1;
        private DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem deleteTableColumnsItem1;
        private DevExpress.XtraRichEdit.UI.DeleteTableRowsItem deleteTableRowsItem1;
        private DevExpress.XtraRichEdit.UI.DeleteTableItem deleteTableItem1;
        private DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem insertTableRowAboveItem1;
        private DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem insertTableRowBelowItem1;
        private DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem insertTableColumnToLeftItem1;
        private DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem insertTableColumnToRightItem1;
        private DevExpress.XtraRichEdit.UI.MergeTableCellsItem mergeTableCellsItem1;
        private DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm showSplitTableCellsForm1;
        private DevExpress.XtraRichEdit.UI.SplitTableItem splitTableItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem toggleTableAutoFitItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem toggleTableAutoFitContentsItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem toggleTableAutoFitWindowItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem toggleTableFixedColumnWidthItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem toggleTableCellsTopLeftAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem toggleTableCellsMiddleLeftAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem toggleTableCellsBottomLeftAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem toggleTableCellsTopCenterAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem toggleTableCellsMiddleCenterAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem toggleTableCellsBottomCenterAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem toggleTableCellsTopRightAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem toggleTableCellsMiddleRightAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem toggleTableCellsBottomRightAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem showTableOptionsFormItem1;
        private DevExpress.XtraRichEdit.UI.CheckSpellingItem checkSpellingItem1;
        private DevExpress.XtraRichEdit.UI.InsertTableOfContentsItem insertTableOfContentsItem1;
        private DevExpress.XtraRichEdit.UI.UpdateTableOfContentsItem updateTableOfContentsItem1;
        private DevExpress.XtraRichEdit.UI.AddParagraphsToTableOfContentItem addParagraphsToTableOfContentItem1;
        private DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem1;
        private DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem2;
        private DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem3;
        private DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem4;
        private DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem5;
        private DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem6;
        private DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem7;
        private DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem8;
        private DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem9;
        private DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem10;
        private DevExpress.XtraRichEdit.UI.InsertCaptionPlaceholderItem insertCaptionPlaceholderItem1;
        private DevExpress.XtraRichEdit.UI.InsertFiguresCaptionItems insertFiguresCaptionItems1;
        private DevExpress.XtraRichEdit.UI.InsertTablesCaptionItems insertTablesCaptionItems1;
        private DevExpress.XtraRichEdit.UI.InsertEquationsCaptionItems insertEquationsCaptionItems1;
        private DevExpress.XtraRichEdit.UI.InsertTableOfFiguresPlaceholderItem insertTableOfFiguresPlaceholderItem1;
        private DevExpress.XtraRichEdit.UI.InsertTableOfFiguresItems insertTableOfFiguresItems1;
        private DevExpress.XtraRichEdit.UI.InsertTableOfTablesItems insertTableOfTablesItems1;
        private DevExpress.XtraRichEdit.UI.InsertTableOfEquationsItems insertTableOfEquationsItems1;
        private DevExpress.XtraRichEdit.UI.UpdateTableOfFiguresItem updateTableOfFiguresItem1;
        private DevExpress.XtraRichEdit.UI.ChangeFloatingObjectFillColorItem changeFloatingObjectFillColorItem1;
        private DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineColorItem changeFloatingObjectOutlineColorItem1;
        private DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineWeightItem changeFloatingObjectOutlineWeightItem1;
        private DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight repositoryItemFloatingObjectOutlineWeight1;
        private DevExpress.XtraRichEdit.UI.ChangeFloatingObjectTextWrapTypeItem changeFloatingObjectTextWrapTypeItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectSquareTextWrapTypeItem setFloatingObjectSquareTextWrapTypeItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectTightTextWrapTypeItem setFloatingObjectTightTextWrapTypeItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectThroughTextWrapTypeItem setFloatingObjectThroughTextWrapTypeItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectTopAndBottomTextWrapTypeItem setFloatingObjectTopAndBottomTextWrapTypeItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectBehindTextWrapTypeItem setFloatingObjectBehindTextWrapTypeItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectInFrontOfTextWrapTypeItem setFloatingObjectInFrontOfTextWrapTypeItem1;
        private DevExpress.XtraRichEdit.UI.ChangeFloatingObjectAlignmentItem changeFloatingObjectAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectTopLeftAlignmentItem setFloatingObjectTopLeftAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectTopCenterAlignmentItem setFloatingObjectTopCenterAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectTopRightAlignmentItem setFloatingObjectTopRightAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleLeftAlignmentItem setFloatingObjectMiddleLeftAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleCenterAlignmentItem setFloatingObjectMiddleCenterAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleRightAlignmentItem setFloatingObjectMiddleRightAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomLeftAlignmentItem setFloatingObjectBottomLeftAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomCenterAlignmentItem setFloatingObjectBottomCenterAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomRightAlignmentItem setFloatingObjectBottomRightAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardSubItem floatingObjectBringForwardSubItem1;
        private DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardItem floatingObjectBringForwardItem1;
        private DevExpress.XtraRichEdit.UI.FloatingObjectBringToFrontItem floatingObjectBringToFrontItem1;
        private DevExpress.XtraRichEdit.UI.FloatingObjectBringInFrontOfTextItem floatingObjectBringInFrontOfTextItem1;
        private DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardSubItem floatingObjectSendBackwardSubItem1;
        private DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardItem floatingObjectSendBackwardItem1;
        private DevExpress.XtraRichEdit.UI.FloatingObjectSendToBackItem floatingObjectSendToBackItem1;
        private DevExpress.XtraRichEdit.UI.FloatingObjectSendBehindTextItem floatingObjectSendBehindTextItem1;
        private DevExpress.Snap.Extensions.UI.ThemesGalleryBarItem themesGalleryBarItem1;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem2;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem3;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem4;
        private DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem1;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem5;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem6;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem7;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem8;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem9;
        private DevExpress.Snap.Extensions.UI.FilterPopupButtonItem filterPopupButtonItem1;
        private DevExpress.Snap.Extensions.UI.PropertiesBarButtonItem propertiesBarButtonItem1;
        private DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem2;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem10;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem11;
        private DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem3;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem12;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem13;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem6;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem7;
        private DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem4;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem14;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem15;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem16;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem17;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem18;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem19;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem20;
        private DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem5;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem21;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem22;
        private DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem6;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem23;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem24;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem8;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem9;
        private DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem7;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem25;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem26;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem27;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem28;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem29;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem30;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem31;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem10;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup8;
        private DevExpress.Snap.Extensions.UI.ChangeEditorRowLimitItem changeEditorRowLimitItem1;
        private DevExpress.Snap.Design.RepositoryItemEditorRowLimitEdit repositoryItemEditorRowLimitEdit1;
        private DevExpress.XtraCharts.UI.CreateBarBaseItem createBarBaseItem1;
        private DevExpress.XtraCharts.UI.CreateLineBaseItem createLineBaseItem1;
        private DevExpress.XtraCharts.UI.CreatePieBaseItem createPieBaseItem1;
        private DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem createRotatedBarBaseItem1;
        private DevExpress.XtraCharts.UI.CreateAreaBaseItem createAreaBaseItem1;
        private DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem createOtherSeriesTypesBaseItem1;
        private DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem changePaletteGalleryBaseItem1;
        private DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseItem changeAppearanceGalleryBaseItem1;
        private DevExpress.XtraCharts.UI.RunWizardChartItem runWizardChartItem1;
        private DevExpress.XtraRichEdit.UI.HeaderFooterToolsRibbonPageCategory headerFooterToolsRibbonPageCategory1;
        private DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignRibbonPage headerFooterToolsDesignRibbonPage1;
        private DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignNavigationRibbonPageGroup headerFooterToolsDesignNavigationRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignOptionsRibbonPageGroup headerFooterToolsDesignOptionsRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignCloseRibbonPageGroup headerFooterToolsDesignCloseRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory tableToolsRibbonPageCategory1;
        private DevExpress.XtraRichEdit.UI.TableDesignRibbonPage tableDesignRibbonPage1;
        private DevExpress.XtraRichEdit.UI.TableStyleOptionsRibbonPageGroup tableStyleOptionsRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup tableStylesRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.TableCellStylesRibbonPageGroup tableCellStylesRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup tableDrawBordersRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage tableLayoutRibbonPage1;
        private DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup tableTableRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup tableRowsAndColumnsRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup tableMergeRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup tableCellSizeRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup tableAlignmentRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.FloatingPictureToolsRibbonPageCategory floatingPictureToolsRibbonPageCategory1;
        private DevExpress.XtraRichEdit.UI.FloatingPictureToolsFormatPage floatingPictureToolsFormatPage1;
        private DevExpress.XtraRichEdit.UI.FloatingPictureToolsShapeStylesPageGroup floatingPictureToolsShapeStylesPageGroup1;
        private DevExpress.XtraRichEdit.UI.FloatingPictureToolsArrangePageGroup floatingPictureToolsArrangePageGroup1;
        private DevExpress.Snap.Extensions.UI.DataToolsRibbonPageCategory dataToolsRibbonPageCategory1;
        private DevExpress.Snap.Extensions.UI.AppearanceRibbonPage appearanceRibbonPage1;
        private DevExpress.Snap.Extensions.UI.ThemesRibbonPageGroup themesRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.SNMergeFieldToolsRibbonPage snMergeFieldToolsRibbonPage1;
        private DevExpress.Snap.Extensions.UI.DataShapingRibbonPageGroup dataShapingRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.SNMergeFieldPropertiesRibbonPageGroup snMergeFieldPropertiesRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.GroupToolsRibbonPage groupToolsRibbonPage1;
        private DevExpress.Snap.Extensions.UI.GroupingRibbonPageGroup groupingRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.ListToolsRibbonPage listToolsRibbonPage1;
        private DevExpress.Snap.Extensions.UI.ListHeaderAndFooterRibbonPageGroup listHeaderAndFooterRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.ListCommandsRibbonPageGroup listCommandsRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.ListEditorRowLimitRibbonPageGroup listEditorRowLimitRibbonPageGroup1;
        private DevExpress.XtraCharts.UI.ChartRibbonPageCategory chartRibbonPageCategory1;
        private DevExpress.XtraCharts.UI.CreateChartRibbonPage createChartRibbonPage1;
        private DevExpress.XtraCharts.UI.ChartTypeRibbonPageGroup chartTypeRibbonPageGroup1;
        private DevExpress.XtraCharts.UI.ChartAppearanceRibbonPageGroup chartAppearanceRibbonPageGroup1;
        private DevExpress.XtraCharts.UI.ChartWizardRibbonPageGroup chartWizardRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.FileRibbonPage fileRibbonPage1;
        private DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup commonRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.DataRibbonPageGroup dataRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.HomeRibbonPage homeRibbonPage1;
        private DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup clipboardRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.FontRibbonPageGroup fontRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup paragraphRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup stylesRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup editingRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.InsertRibbonPage insertRibbonPage1;
        private DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup pagesRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup tablesRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup illustrationsRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.ToolboxRibbonPageGroup toolboxRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup linksRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup headerFooterRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.TextRibbonPageGroup textRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup symbolsRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage pageLayoutRibbonPage1;
        private DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup pageSetupRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.PageBackgroundRibbonPageGroup pageBackgroundRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.ViewRibbonPage viewRibbonPage1;
        private DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup documentViewsRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup showRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup zoomRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.ViewRibbonPageGroup viewRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup mailMergeRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.ReviewRibbonPage reviewRibbonPage1;
        private DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup documentProofingRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.ReferencesRibbonPage referencesRibbonPage1;
        private DevExpress.XtraRichEdit.UI.TableOfContentsRibbonPageGroup tableOfContentsRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.CaptionsRibbonPageGroup captionsRibbonPageGroup1;
        private DevExpress.Snap.Extensions.SnapBarController snapBarController1;
        private DevExpress.XtraRichEdit.UI.InsertPageBreakItem insertPageBreakItem2;
    }
}

