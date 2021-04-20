using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using FootballersTeam.MvcClient.Data;
using FootballersTeam.MvcClient.Helpers;
using FootballersTeam.MvcClient.Mapper;
using FootballersTeam.MvcClient.Models;
using FootballProject.Entities;
using GemBox.Spreadsheet;
using Microsoft.AspNetCore.Mvc;

namespace FootballersTeam.MvcClient.Controllers
{
    public class WorkbookController : Controller
    {
        private readonly IMapper<Footballer, FootballerViewModel> _footballerMapper;

        public WorkbookController(IMapper<Footballer, FootballerViewModel> footballerMapper)
        {
            _footballerMapper = footballerMapper;
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
        }

        [HttpGet]
        public IActionResult GenerateFromDataSet()
        {
            return View(new WorkbookModel()
            {
                Items = FootballersData.GetFootballersData()
                    .Select(e => _footballerMapper.MapToModel(e))?
                    .ToList(),

                SelectedFormat = "XLSX"
            });
        }


        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult GenerateFromDataSet(WorkbookModel model)
        {

            if (!ModelState.IsValid)
                return View(model);

            var workbook = new ExcelFile();
            var worksheet = workbook.Worksheets.Add("DataTable to Sheet");
            SetHeaders(worksheet, workbook);
            RenderFootballersData(worksheet, model);

            SaveOptions options = GetSaveOptions(model.SelectedFormat);

            using var stream = new MemoryStream();
            workbook.Save(stream, options);
            return File(stream.ToArray(), options.ContentType, "Create." + model.SelectedFormat.ToLower());
        }

        private void SetHeaders(ExcelWorksheet worksheet, ExcelFile workbook)
        {
            worksheet.Cells[0, 0].Value = "DataTable insert example:";
            worksheet.Rows["1"].Style = workbook.Styles[BuiltInCellStyleName.Heading1];
            worksheet.Cells["A1"].Value = nameof(Role.RoleId);
            worksheet.Cells["B1"].Value = nameof(Role.RoleName);
            worksheet.Cells["C1"].Value = nameof(FootballerViewModel.PersonId);
            worksheet.Cells["D1"].Value = nameof(FootballerViewModel.FirstName);
            worksheet.Cells["E1"].Value = nameof(FootballerViewModel.MiddleName);
            worksheet.Cells["F1"].Value = nameof(FootballerViewModel.DataOfBirth);
            worksheet.Cells["G1"].Value = nameof(FootballerViewModel.PlaceOfBirth);
            worksheet.Cells["H1"].Value = nameof(FootballerViewModel.Nationality);
            worksheet.Cells["I1"].Value = nameof(FootballerViewModel.Weight);
            worksheet.Cells["J1"].Value = nameof(FootballerViewModel.Height);
        }
        private void RenderFootballersData(ExcelWorksheet worksheet, WorkbookModel model)
        {
            for (int r = 1; r < model?.Items.Count; r++)
            {
                FootballerViewModel item = model.Items[r - 1];
                worksheet.Cells[r, 0].Value = item.RoleId;
                worksheet.Cells[r, 1].Value = item.RoleName;
                worksheet.Cells[r, 2].Value = item.PersonId;
                worksheet.Cells[r, 3].Value = item.FirstName;
                worksheet.Cells[r, 4].Value = item.MiddleName;
                worksheet.Cells[r, 5].Value = item.DataOfBirth;
                worksheet.Cells[r, 6].Value = item.PlaceOfBirth;
                worksheet.Cells[r, 7].Value = item.Nationality;
                worksheet.Cells[r, 8].Value = item.Weight;
                worksheet.Cells[r, 9].Value = item.Height;
            }
        }


        private SaveOptions GetSaveOptions(string format)
        {
            switch (format.ToUpper())
            {
                case "XLSX":
                    return SaveOptions.XlsxDefault;
                case "XLS":
                    return SaveOptions.XlsDefault;
                case "ODS":
                    return SaveOptions.OdsDefault;
                case "CSV":
                    return SaveOptions.CsvDefault;
                case "HTML":
                    return SaveOptions.HtmlDefault;
                case "PDF":
                    return SaveOptions.PdfDefault;
                default:
                    throw new NotSupportedException();
            }
        }
    }

}
