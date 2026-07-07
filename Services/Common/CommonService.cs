using Dapper;
using HulasApplication.Model;
using HulasApplication.Model.MotorApi;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HulasApplication.Services.Common
{
    public class CommonService : BaseRepository, ICommonService
    {
        private readonly ILogger<CommonService> _logger;
        public CommonService(IConfiguration configuration, ILogger<CommonService> logger) : base(configuration)
        {
            //_commandText = commandText;
            _logger = logger;

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
        public async Task<int> InsertCommonPolicyDetails(CommonPolicyDetails commonPolicyDetails)
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
                    ClientBankId = commonPolicyDetails.clientBankId,
                    BankBranchId = commonPolicyDetails.bankBranchId,
                    commonPolicyDetails.EffectiveDt,
                    commonPolicyDetails.ExpiryDate
                });

                return returnId;
            });
        }
        public async Task<int> InsertKYCDetails(KycDetail kycDetails)
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
                    MunicipalityCode = 0,
                    kycDetails.WardNo,
                    HouseNo = 0,
                    kycDetails.MobileNo,
                    kycDetails.Email,
                    Panno = kycDetails.PanNo,
                    kycDetails.FatherName,
                    kycDetails.DateOfBirth,
                    kycDetails.CitizenshipNo,
                    kycDetails.IssueDate,
                    IssueDistrictId = kycDetails.IssueDistrictID,
                    kycDetails.MotherName,
                    kycDetails.MaritalStatus,
                    kycDetails.SpouseName
                });

                return returnId;
            });
        }
        public async Task<bool> InsertPhoto(List<KycPhoto> photos)
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

        public async Task<int> InsertPremiumDetail(PremiumDetails premiumDetail)
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
                    VatRate = premiumDetail.VATRATE,
                    VatAmt = premiumDetail.VATAMT,
                    premiumDetail.TotalPayablePremium
                });

                return returnId;
            });
        }
        public async Task<int> InsertMotorDetails(MotorDetails motorDetails)
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
                    YearManufacture = motorDetails.YEARMANUFACTURE,
                    motorDetails.CCHP,
                    TypeCover = motorDetails.TYPECOVER,
                    CategoryId = motorDetails.CATEGORYID,
                    motorDetails.VehicleCost,
                    EodAmt = motorDetails.EODAMT,
                    NcYr = motorDetails.NCDYR,
                    IncludeTowing = motorDetails.INCLUDETOWING,
                    IsGovernment = motorDetails.ISGOVERNMENT,
                    ExcludePool = motorDetails.EXCLUDEPOOL,
                    motorDetails.ManufactureCompanyId,
                    HasTrailor = motorDetails.HASTRAILOR,
                    motorDetails.CompanyVehicleModelId,
                    motorDetails.VehicleFormationId,
                    CarryCapacity = motorDetails.CARRYCAPACITY,
                    RegDate = motorDetails.REGDATE,
                    motorDetails.VehicleNoEnglish,
                    motorDetails.RunningVehicleNoEnglish,
                    EngineNo = motorDetails.ENGINENO,
                    ChasisNo = motorDetails.CHASISNO,
                    motorDetails.NoOfEmployee,
                    motorDetails.NoOfSeat,
                    motorDetails.TrailorSI,
                    motorDetails.TrailorSIDesc
                });

                return returnId;
            });
        }
        public async Task<bool> InsertProductAttachment(List<ProductAttachment> productAttachments)
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
        public async Task<int> InsertMotorProforma(OutputObject1 apiResponse, SaveMotorProforma model,int kycDetailsId)
        {
            var insertQuery = @"
            INSERT INTO [dbo].[MotorProformaSuccess]
            (
                [Flag], [SuccFailMsg], [ProformaNo], [Insured], [ClassName], [KycNo], [KycId],[KycDetailsId],
                [SumInsured], [TpPremium], [DocumentNo], [ReceiptNo], [ReceiptDate], [EffectiveDate], [ExpiryDate],
                [PolicyNo], [TransactionStatus], [AcceptanceNo],
                [Name], [ContactNumber], [VehicleNumber]
            )
            OUTPUT Inserted.Id
            VALUES
            (
                @Flag, @SuccFailMsg, @ProformaNo, @Insured, @ClassName, @KycNo, @KycId,@KycDetailsId,
                @SumInsured, @TpPremium, @DocumentNo, @ReceiptNo, @ReceiptDate, @EffectiveDate, @ExpiryDate,
                @PolicyNo, @TransactionStatus, @AcceptanceNo,
                @Name, @ContactNumber, @VehicleNumber
    
            )";

            return await WithConnection(async conn =>
            {
                var returnId = await conn.QuerySingleOrDefaultAsync<int>(insertQuery, new
                {
                    Flag = apiResponse.Flag,
                    SuccFailMsg = apiResponse.SuccFailMsg,
                    ProformaNo = apiResponse.ProformaNo,
                    Insured = apiResponse.Insured,
                    ClassName = apiResponse.ClassName,
                    KycNo = apiResponse.KycNo,
                    KycId = apiResponse.KycId,
                    SumInsured = apiResponse.SumInsured,
                    TpPremium = apiResponse.TpPremium,
                    DocumentNo = apiResponse.DocumentNo,
                    ReceiptNo = apiResponse.ReceiptNo,
                    ReceiptDate = apiResponse.ReceiptDate,
                    EffectiveDate = apiResponse.EffectiveDate,
                    ExpiryDate = apiResponse.ExpiryDate,
                    PolicyNo = apiResponse.PolicyNo,
                    TransactionStatus = apiResponse.TransactionStatus,
                    AcceptanceNo = apiResponse.AcceptanceNo,
                    kycDetailsId = kycDetailsId,

                    Name = model.kycDetails.Name,
                    ContactNumber = model.kycDetails.MobileNo,
                    VehicleNumber = model.MotorDetails.VehicleNoEnglish,
                });

                return returnId;
            });
        }

        public async Task<int> InsertFailedMotorProforma(SaveMotorProforma model, string failureReason)

        {
            var insertQuery = @"
            INSERT INTO dbo.MotorProformaFailed
            (
                Name,
                CurrentAddress,
                MobileNo,
                PanNo,
                CitizenshipNo,
                ManufacturedYear,
                CCHP,
                VehicleCost,
                VehicleName,
                VehicleNumber,
                RunningVehicleNumber,
                EngineNo,
                ChassisNo,
                EOD,
                TotalPremium,
                FailureReason,
                CreatedDate,
                CareOf
            )
                OUTPUT Inserted.Id
                VALUES
                (
                @Name,
                @CurrentAddress,
                @MobileNo,
                @PanNo,
                @CitizenshipNo,
                @ManufacturedYear,
                @CCHP,
                @VehicleCost,
                @VehicleName,
                @VehicleNumber,
                @RunningVehicleNumber,
                @EngineNo,
                @ChassisNo,
                @EOD,
                @TotalPremium,
                @FailureReason,
                GETDATE(),
                @CareOf
                )";

            return await WithConnection(async conn =>
            {
                return await conn.QuerySingleOrDefaultAsync<int>(
                    insertQuery,
                    new
                    {
                        Name = model.kycDetails?.Name,
                        CurrentAddress = model.kycDetails?.CurrentAddress,
                        MobileNo = model.kycDetails?.MobileNo,
                        PanNo = model.kycDetails?.PanNo,
                        CitizenshipNo = model.kycDetails?.CitizenshipNo,

                        ManufacturedYear = model.MotorDetails?.YEARMANUFACTURE,
                        CCHP = model.MotorDetails?.CCHP,
                        VehicleCost = model.MotorDetails?.VehicleCost,
                        VehicleName = model.MotorDetails?.CompanyVehicleName,

                        VehicleNumber = model.MotorDetails?.VehicleNoEnglish,
                        RunningVehicleNumber = model.MotorDetails?.RunningVehicleNoEnglish,

                        EngineNo = model.MotorDetails?.ENGINENO,
                        ChassisNo = model.MotorDetails?.CHASISNO,
                        EOD = model.MotorDetails?.EODAMT,

                        TotalPremium = model.PremiumDetails?.TotalPayablePremium,

                        FailureReason = failureReason,
                        CareOf = model.CommonPolicyDetails.CareOf
                    });
            });
        }

    }
}
