﻿using Contratos;
using Mocks;
using MVCGrid.Models;
using MVCGrid.Web;
using Newtonsoft.Json;
using System.Linq;
using WebApp;
using WebApp.Controllers;
using LogicaImplementar;

namespace WebApp.Grid
{
	public static class AlumnosGrid
	{
		internal static void Register()
		{
			GridDefaults employeeGridDefauls = new GridDefaults()
			{
				Paging = true,
				ItemsPerPage = 10,
				Sorting = true,
				NoResultsMessage = "No hay mas usuarios para mostrar",
				NextButtonCaption = string.Empty,
				PreviousButtonCaption = string.Empty,
				SummaryMessage = "Viendo {0} a {1} de {2} registros"
			};

			MVCGridDefinitionTable.Add("AlumnosGrid", new MVCGridBuilder<Hijo>(employeeGridDefauls)
				  .WithAuthorizationType(AuthorizationType.AllowAnonymous)
				  .AddColumns(cols =>
				  {
						  // Add your columns here

						  cols.Add().WithColumnName("Nombre").WithHeaderText("Nombre").WithValueExpression(i => i.Nombre).WithSorting(false);
						  cols.Add().WithColumnName("Apellido").WithHeaderText("Apellido").WithValueExpression(i => i.Apellido).WithSorting(false);
						  cols.Add().WithColumnName("Email").WithHeaderText("Email").WithValueExpression(i => i.Email).WithSorting(false);					  
						  cols.Add().WithColumnName("Sala").WithHeaderText("Sala").WithValueExpression(i => i.Sala?.Nombre).WithSorting(false);					  
					  cols.Add().WithColumnName("Details").WithHeaderText("").WithCellCssClassExpression((i, c) => "action").WithHtmlEncoding(false)
								.WithValueExpression((i, c) =>
									  string.Format("{0}{1}",                                      
                                        string.Format("<a data-modal='' class='text-info' href='{0}' id='{1}' title='Editar'><span class='fa fa-pencil'></span></a>", c.UrlHelper.Action("Form", "Alumnos", new { id = i.Id }), i.Id),
										string.Format("<a data-modal='' class='text-info' href='{0}' id='{1}' title='Eliminar'><span class='fa fa-trash'></span></a>", c.UrlHelper.Action("Form", "Alumnos", new { id = i.Id, readOnly = true, delete = true }), i.Id)
									  ));
				  })
				  .WithPaging(true, 10, true, 100)
				  .WithSorting(true, "Id")
				  .WithAdditionalQueryOptionNames("search")
                  .WithPageParameterNames("user")
				  .WithRetrieveDataMethod((context) =>
				  {
					  var options = context.QueryOptions;
					  var result = new QueryResult<Hijo>();

                      string globalSearch = options.GetAdditionalQueryOptionString("search");
                      UsuarioLogueado usuarioLogueado = JsonConvert.DeserializeObject<UsuarioLogueado>(options.GetPageParameterString("user"));

                      IServicioWeb servicio = new Implementacion();
                      var data = servicio.ObtenerAlumnos(usuarioLogueado, options.PageIndex.Value, options.ItemsPerPage.Value, globalSearch);

					  return new QueryResult<Hijo>()
					  {
						  Items = data.Lista.ToArray(),
						  TotalRecords = data.CantidadRegistros,
					  };

				  })
			);
		}
	}
}
