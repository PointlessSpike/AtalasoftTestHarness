using Atalasoft.Imaging;
using Atalasoft.Imaging.Codec;

Console.WriteLine("Setting up license");

Atalasoft.Licensing.AtalaLicense.SetAssemblyLicense(@"<?xml version='1.0' encoding='utf-8'?>
			<License>
				<Assembly>Atalasoft.dotImage.Dicom</Assembly>
				<Assembly>Atalasoft.dotImage</Assembly>
				<Assembly>Atalasoft.dotImage.FormsProcessing</Assembly>
				<Assembly>Atalasoft.DotTwain</Assembly>
				<Assembly>Atalasoft.dotImage.Dwg</Assembly>
				<Assembly>Atalasoft.dotImage.Jbig2</Assembly>
				<Assembly>Atalasoft.dotImage.Jpeg2000</Assembly>
				<Assembly>Atalasoft.dotImage.Pdfium</Assembly>
				<Version>11.4</Version>
				<Name>ATALASOFT_PKL_OITUK_AZURE_v11.4_2023-01-03</Name>
				<ServerCPUs>3200</ServerCPUs>
				<ServerIP>*</ServerIP>
				<PublicKey>0240048000940006200024005253413104001010d30af1b55a079fb277818c28694919d504872f7fec911c98bc69ad16d1217129e4d596a54ea84726a13c1fde79d73d14d99f5eaee973f2d366887cfada8c36f8bf921e3b64c4fbb4de8b2f2f4a55031d73873b2dceda2bfde1461dd25c65d5f43f9c91876a4cb3c442bbdff89aeef3a6ae588f2f149a443a4bd8a99a</PublicKey>
				<Flag name='Document' />
				<Flag name='v2Signature' />
				<Flag name='Professional' />
				<Flag name='AdvancedPhotoEffects' />
				<Flag name='AdvancedDocClean' />
				<Signature>SGeRU2n3jua+ZCfAEDDD/WQGdSFbfim6qeh+mBjjXzX43Z1cNeGIFKKuEmCU+yr4hDbLcJLaWYlmP3VoK/bdvGcAsCwYvM5wJzFBAUQaw9YrAnyV62fpQxMcYEJfyxafNfeiEGipLQH7TOZTj8Iq2XQ6FFEyH/9NTmp+ism1S1U=</Signature>
			</License>");

Console.WriteLine("Performing TIF resave");

var ecgAtalaImage = new AtalaImage("ECG Source.tif", null);

var tifEncoder = new TiffEncoder()
{
	Append = false,
	Compression = TiffCompression.JpegCompression,
	JpegQuality = 100
};

ecgAtalaImage.Save("Result.tif", tifEncoder, null);

Console.WriteLine("Save successful. Files are available in \\bin\\Debug\\net7.0-windows");