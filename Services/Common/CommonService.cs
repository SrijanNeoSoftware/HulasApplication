using Dapper;
using HulasApplication.Model;
using HulasApplication.Model.MotorApi;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HulasApplication.Services.Common
{
	public class CommonService : BaseRepository, ICommonService
	{
		public CommonService(IConfiguration configuration) : base(configuration)
		{
			//_commandText = commandText;

		}

		public async Task<Insurers> GetInsurers(int Id)
		{
			try
			{
				var InsertManufacturer = @$"select * from Insurers where Id={Id}";

				return await WithConnection(async conn =>
				{
					var ReturnId = await conn.QueryFirstOrDefaultAsync<Insurers>(InsertManufacturer);
					return ReturnId;
				});
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public async Task<int> InsertCommonPolicyDetails(HulasCommonPolicyDetails commonPolicyDetails)
		{
			var insertQuery = $@"INSERT INTO [dbo].[HulasCommonPolicyDetails]
       ([KycId], [ClassId], [ClientBankId], [BankBranchId], [EffectiveDt], [ExpiryDate], [CreatedDate])
       OUTPUT Inserted.Id
       VALUES(@KycId, @ClassId, @ClientBankId, @BankBranchId, @EffectiveDt, @ExpiryDate, GETDATE())";
			return await WithConnection(async conn =>
			{
				var returnId = await conn.QuerySingleOrDefaultAsync<int>(insertQuery, new
				{
					commonPolicyDetails.KycId,
					commonPolicyDetails.ClassId,
					commonPolicyDetails.ClientBankId,
					commonPolicyDetails.BankBranchId,
					commonPolicyDetails.EffectiveDt,
					commonPolicyDetails.ExpiryDate
				});

				return returnId;
			});
		}
		public async Task<int> InsertKYCDetails(HulasKYCDetails kycDetails)
		{
			var insertQuery = $@"INSERT INTO [dbo].[HulasKYCDetails]
       ([Name], [Gender], [CurrentAddress], [DistrictId], [MunicipalityCode], [WardNo], [HouseNo], [MobileNo], 
        [Email], [Panno], [FatherName], [DateOfBirth], [CitizenshipNo], [IssueDate], [IssueDistrictId], [MotherName], 
        [MaritalStatus], [SpouseName], [CreatedDate])
       OUTPUT Inserted.Id
       VALUES(@Name, @Gender, @CurrentAddress, @DistrictId, @MunicipalityCode, @WardNo, @HouseNo, @MobileNo, 
              @Email, @Panno, @FatherName, @DateOfBirth, @CitizenshipNo, @IssueDate, @IssueDistrictId, @MotherName, 
              @MaritalStatus, @SpouseName, GETDATE())";
			return await WithConnection(async conn =>
			{
				var returnId = await conn.QuerySingleOrDefaultAsync<int>(insertQuery, new
				{
					kycDetails.Name,
					kycDetails.Gender,
					kycDetails.CurrentAddress,
					kycDetails.DistrictId,
					kycDetails.MunicipalityCode,
					kycDetails.WardNo,
					kycDetails.HouseNo,
					kycDetails.MobileNo,
					kycDetails.Email,
					kycDetails.Panno,
					kycDetails.FatherName,
					kycDetails.DateOfBirth,
					kycDetails.CitizenshipNo,
					kycDetails.IssueDate,
					kycDetails.IssueDistrictId,
					kycDetails.MotherName,
					kycDetails.MaritalStatus,
					kycDetails.SpouseName
				});

				return returnId;
			});
		}
		public async Task<bool> InsertPhoto(List<HulasPhoto> photos)
		{
			try
			{
				foreach (var photo in photos)
				{
					var insertQuery = $@"INSERT INTO [dbo].[HulasPhoto]
           ([KycId], [FileName], [KycImage], [CreatedDate])
           VALUES(@KycId, @FileName, @KycImage, GETDATE())";

					await WithConnection(async conn =>
					{
						await conn.ExecuteAsync(insertQuery, new
						{
							KycId = photo.KycId,
							FileName = photo.FileName,
							KycImage = photo.KycImage
						});
					});
				}
				return true;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public async Task<int> InsertPremiumDetail(HulasPremiumDetail premiumDetail)
		{
			var insertQuery = $@"INSERT INTO [dbo].[HulasPremiumDetail]
       ([KycId], [NetPayablePremium], [StampDuty], [VatRate], [VatAmt], [TotalPayablePremium], [CreatedDate])
       OUTPUT Inserted.Id
       VALUES(@KycId, @NetPayablePremium, @StampDuty, @VatRate, @VatAmt, @TotalPayablePremium, GETDATE())";
			return await WithConnection(async conn =>
			{
				var returnId = await conn.QuerySingleOrDefaultAsync<int>(insertQuery, new
				{
					premiumDetail.KycId,
					premiumDetail.NetPayablePremium,
					premiumDetail.StampDuty,
					premiumDetail.VatRate,
					premiumDetail.VatAmt,
					premiumDetail.TotalPayablePremium
				});

				return returnId;
			});
		}
		public async Task<int> InsertMotorDetails(HulasMotorDetails motorDetails)
		{
			var insertQuery = $@"INSERT INTO [dbo].[HulasMotorDetails]
       ([KycId], [YearManufacture], [CCHP], [TypeCover], [CategoryId], [VehicleCost], [EodAmt], [NcYr], [IncludeTowing], 
        [IsGovernment], [ExcludePool], [ManufactureCompanyId], [HasTrailor], [CompanyVehicleModelId], [VehicleFormationId], 
        [CarryCapacity], [RegDate], [VehicleNoEnglish], [RunningVehicleNoEnglish], [EngineNo], [ChasisNo], [NoOfEmployee], 
        [NoOfSeat], [TrailorSI], [TrailorSIDesc], [CreatedDate])
       OUTPUT Inserted.Id
       VALUES(@KycId, @YearManufacture, @CCHP, @TypeCover, @CategoryId, @VehicleCost, @EodAmt, @NcYr, @IncludeTowing, 
              @IsGovernment, @ExcludePool, @ManufactureCompanyId, @HasTrailor, @CompanyVehicleModelId, @VehicleFormationId, 
              @CarryCapacity, @RegDate, @VehicleNoEnglish, @RunningVehicleNoEnglish, @EngineNo, @ChasisNo, @NoOfEmployee, 
              @NoOfSeat, @TrailorSI, @TrailorSIDesc, GETDATE())";
			return await WithConnection(async conn =>
			{
				var returnId = await conn.QuerySingleOrDefaultAsync<int>(insertQuery, new
				{
					motorDetails.KycId,
					motorDetails.YearManufacture,
					motorDetails.CCHP,
					motorDetails.TypeCover,
					motorDetails.CategoryId,
					motorDetails.VehicleCost,
					motorDetails.EodAmt,
					motorDetails.NcYr,
					motorDetails.IncludeTowing,
					motorDetails.IsGovernment,
					motorDetails.ExcludePool,
					motorDetails.ManufactureCompanyId,
					motorDetails.HasTrailor,
					motorDetails.CompanyVehicleModelId,
					motorDetails.VehicleFormationId,
					motorDetails.CarryCapacity,
					motorDetails.RegDate,
					motorDetails.VehicleNoEnglish,
					motorDetails.RunningVehicleNoEnglish,
					motorDetails.EngineNo,
					motorDetails.ChasisNo,
					motorDetails.NoOfEmployee,
					motorDetails.NoOfSeat,
					motorDetails.TrailorSI,
					motorDetails.TrailorSIDesc
				});

				return returnId;
			});
		}
		public async Task<bool> InsertProductAttachment(List<HulasProductAttachment> productAttachments)
		{
			try
			{
				foreach (var attachment in productAttachments)
				{
					var insertQuery = $@"INSERT INTO [dbo].[HulasProductAttachment]
           ([KycId], [DocumentName], [DocumentFile], [CreatedDate])
           VALUES(@KycId, @DocumentName, @DocumentFile, GETDATE())";

					await WithConnection(async conn =>
					{
						await conn.ExecuteAsync(insertQuery, new
						{
							KycId = attachment.KycId,
							DocumentName = attachment.DocumentName,
							DocumentFile = attachment.DocumentFile
						});
					});
				}
				return true;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

	}
}
