using System;
using System.Configuration;
using System.Windows.Forms;

namespace BioData_DB
{
	class Class1
	{
		public static string ConnectionString()
		{
			return ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
		}

		public static void Height(ComboBox comboBox)
		{
			comboBox.Items.Add("4ft 6in (137 cm)");
			comboBox.Items.Add("4ft 7in (140 cm)");
			comboBox.Items.Add("4ft 8in (142 cm)");
			comboBox.Items.Add("4ft 9in (145 cm)");
			comboBox.Items.Add("4ft 10in (147 cm)");
			comboBox.Items.Add("4ft 11in (150 cm)");
			comboBox.Items.Add("5ft 0in (152 cm)");
			comboBox.Items.Add("5ft 1in (155 cm)");
			comboBox.Items.Add("5ft 2in (157 cm)");
			comboBox.Items.Add("5ft 3in (160 cm)");
			comboBox.Items.Add("5ft 4in (163 cm)");
			comboBox.Items.Add("5ft 5in (165 cm)");
			comboBox.Items.Add("5ft 6in (168 cm)");
			comboBox.Items.Add("5ft 7in (170 cm)");
			comboBox.Items.Add("5ft 8in (173 cm)");
			comboBox.Items.Add("5ft 9in (175 cm)");
			comboBox.Items.Add("5ft 10in (178 cm)");
			comboBox.Items.Add("5ft 11in (180 cm)");
			comboBox.Items.Add("6ft 0in (183 cm)");
			comboBox.Items.Add("6ft 1in (185 cm)");
			comboBox.Items.Add("6ft 2in (188 cm)");
			comboBox.Items.Add("6ft 3in (191 cm)");
			comboBox.Items.Add("6ft 4in (193 cm)");
			comboBox.Items.Add("6ft 5in (195 cm)");
			comboBox.Items.Add("6ft 6in (198 cm)");
			comboBox.Items.Add("6ft 7in (201 cm)");
			comboBox.Items.Add("6ft 8in (203 cm)");
			comboBox.Items.Add("6ft 9in (205 cm)");
			comboBox.Items.Add("6ft 10in (208 cm)");
			comboBox.Items.Add("6ft 11in (210 cm)");
			comboBox.Items.Add("7ft 0in (213 cm)");
		}

		public static void BloodGroup(ComboBox comboBox)
		{
			comboBox.Items.Add("Unknown");
			comboBox.Items.Add("A+");
			comboBox.Items.Add("A-");
			comboBox.Items.Add("B+");
			comboBox.Items.Add("B-");
			comboBox.Items.Add("AB+");
			comboBox.Items.Add("AB-");
			comboBox.Items.Add("O+");
			comboBox.Items.Add("O-");
		}

		public static void Qualification(ComboBox comboBox)
		{
			comboBox.Items.Add("Matriculation / O level");
			comboBox.Items.Add("Intermediate / A level");
			comboBox.Items.Add("Undergraduate");
			comboBox.Items.Add("Bechelor");
			comboBox.Items.Add("Master");
			comboBox.Items.Add("Ph.D");
		}

		public static void City(ComboBox comboBox)
		{
			comboBox.Items.Add("Karachi");
			comboBox.Items.Add("Lahore");
			comboBox.Items.Add("Faisalabad");
			comboBox.Items.Add("Rawalpindi");
			comboBox.Items.Add("Multan");
			comboBox.Items.Add("Hyderabad");
			comboBox.Items.Add("Gujranwala");
			comboBox.Items.Add("Peshawar");
			comboBox.Items.Add("Rahim Yar Khan");
			comboBox.Items.Add("Quetta");
			comboBox.Items.Add("Muzaffarabad");
			comboBox.Items.Add("Battagram");
			comboBox.Items.Add("Kotli");
			comboBox.Items.Add("Islamabad");
			comboBox.Items.Add("Bahawalpur");
			comboBox.Items.Add("Sargodha");
			comboBox.Items.Add("Sialkot");
			comboBox.Items.Add("Sukkur");
			comboBox.Items.Add("Larkana");
			comboBox.Items.Add("Shekhupura");
			comboBox.Items.Add("Bhimbar");
			comboBox.Items.Add("Jhang Sadr");
			comboBox.Items.Add("Gujrat");
			comboBox.Items.Add("Mardan");
			comboBox.Items.Add("Malir Cantonment");
			comboBox.Items.Add("Kasur");
			comboBox.Items.Add("Mingora");
			comboBox.Items.Add("Dera Ghazi Khan");
			comboBox.Items.Add("Sahiwal");
			comboBox.Items.Add("Nawabshah");
			comboBox.Items.Add("Okara");
			comboBox.Items.Add("Mirpur Khas");
			comboBox.Items.Add("Chiniot");
			comboBox.Items.Add("Shahkot");
			comboBox.Items.Add("Kamoke");
			comboBox.Items.Add("Saddiqabad");
			comboBox.Items.Add("Burewala");
			comboBox.Items.Add("Jacobabad");
			comboBox.Items.Add("Muzaffargarh");
			comboBox.Items.Add("Muridke");
			comboBox.Items.Add("Jhelum");
			comboBox.Items.Add("Shikarpur");
			comboBox.Items.Add("Hafizabad");
			comboBox.Items.Add("Kohat");
			comboBox.Items.Add("Khanpur");
			comboBox.Items.Add("Khuzdar");
			comboBox.Items.Add("Dadu");
			comboBox.Items.Add("Gojra");
			comboBox.Items.Add("Mandi Bahauddin");
			comboBox.Items.Add("Tando Allahyar");
			comboBox.Items.Add("Daska Kalan");
			comboBox.Items.Add("Pakpattan");
			comboBox.Items.Add("Bahawalnagar");
			comboBox.Items.Add("Bahawalnagar");
			comboBox.Items.Add("Tando Adam");
			comboBox.Items.Add("Khairpur Mirs");
			comboBox.Items.Add("Chishtian");
			comboBox.Items.Add("Abbottabad");
			comboBox.Items.Add("Jaranwala");
			comboBox.Items.Add("Ahmadpur East");
			comboBox.Items.Add("Vihari");
			comboBox.Items.Add("Kamalia");
			comboBox.Items.Add("Kot Addu");
			comboBox.Items.Add("Khushab");
			comboBox.Items.Add("Wazirabad");
			comboBox.Items.Add("Dera Ismail Khan");
			comboBox.Items.Add("Chakwal");
			comboBox.Items.Add("Swabi");
			comboBox.Items.Add("Lodhran");
			comboBox.Items.Add("Nowshera Cantonment");
			comboBox.Items.Add("Charsadda");
			comboBox.Items.Add("Jalalpur Jattan");
			comboBox.Items.Add("Mianwali");
			comboBox.Items.Add("Chaman");
			comboBox.Items.Add("Kandhkot");
			comboBox.Items.Add("Hasilpur");
			comboBox.Items.Add("Arifwala");
			comboBox.Items.Add("Mianke Mor");
			comboBox.Items.Add("Attock City");
			comboBox.Items.Add("Chichawatni");
			comboBox.Items.Add("Bhakkar");
			comboBox.Items.Add("Kharian");
			comboBox.Items.Add("Layyah");
			comboBox.Items.Add("Kambar");
			comboBox.Items.Add("Moro");
			comboBox.Items.Add("Mian Channun");
			comboBox.Items.Add("Turbat");
			comboBox.Items.Add("Shahdad Kot");
			comboBox.Items.Add("Bhalwal");
			comboBox.Items.Add("Dipalpur");
			comboBox.Items.Add("Badin");
			comboBox.Items.Add("Pano Aqil");
			comboBox.Items.Add("Kotri");
			comboBox.Items.Add("Tando Muhammad Khan");
			comboBox.Items.Add("Harunabad");
			comboBox.Items.Add("Pattoki");
			comboBox.Items.Add("Chenab Nagar");
			comboBox.Items.Add("Kahror Pakka");
			comboBox.Items.Add("Gujar Khan");
			comboBox.Items.Add("Kot Malik Barkhurdar");
			comboBox.Items.Add("Chuchar-kana Mandi");
			comboBox.Items.Add("Toba Tek Singh");
			comboBox.Items.Add("Narowal");
			comboBox.Items.Add("Shorkot");
			comboBox.Items.Add("Shahdadpur");
			comboBox.Items.Add("Shabqadar");
			comboBox.Items.Add("Mansehra");
			comboBox.Items.Add("Shujaabad");
			comboBox.Items.Add("Haveli Lakha");
			comboBox.Items.Add("Lala Musa");
			comboBox.Items.Add("Mailsi");
			comboBox.Items.Add("Shakargarh");
			comboBox.Items.Add("Ghotki");
			comboBox.Items.Add("Sibi");
			comboBox.Items.Add("Jampur");
			comboBox.Items.Add("Sambrial");
			comboBox.Items.Add("Sanghar");
			comboBox.Items.Add("Hujra Shah Muqim");
			comboBox.Items.Add("Kabirwala");
			comboBox.Items.Add("Chunian");
			comboBox.Items.Add("Sangla Hill");
			comboBox.Items.Add("Haripur");
			comboBox.Items.Add("Nankana Sahib");
			comboBox.Items.Add("Pasrur");
			comboBox.Items.Add("Gwadar");
			comboBox.Items.Add("Rajanpur");
			comboBox.Items.Add("Rohri");
			comboBox.Items.Add("Zhob");
			comboBox.Items.Add("Matli");
			comboBox.Items.Add("Rawala Kot");
			comboBox.Items.Add("Hadali");
			comboBox.Items.Add("Mirpur Mathelo");
			comboBox.Items.Add("Bannu");
			comboBox.Items.Add("Dullewala");
			comboBox.Items.Add("Hala");
			comboBox.Items.Add("Ratodero");
			comboBox.Items.Add("Jatoi Shimali");
			comboBox.Items.Add("Jauharabad");
			comboBox.Items.Add("Bat Khela");
			comboBox.Items.Add("Kot Radha Kishan");
			comboBox.Items.Add("Kahna Nau");
			comboBox.Items.Add("Mustafabad");
			comboBox.Items.Add("Chak Thirty-one -Eleven Left");
			comboBox.Items.Add("Talagang");
			comboBox.Items.Add("Taunsa");
			comboBox.Items.Add("Thatta");
			comboBox.Items.Add("Sarai Alamgir");
			comboBox.Items.Add("Usta Muhammad");
			comboBox.Items.Add("Kamra");
			comboBox.Items.Add("Umarkot");
			comboBox.Items.Add("Basirpur");
			comboBox.Items.Add("Sehwan");
			comboBox.Items.Add("Naushahra Virkan");
			comboBox.Items.Add("Fort Abbas");
			comboBox.Items.Add("Havelian");
			comboBox.Items.Add("Khairpur");
			comboBox.Items.Add("Dinga");
			comboBox.Items.Add("Ladhewala Waraich");
			comboBox.Items.Add("Khalabat");
			comboBox.Items.Add("New Badah");
			comboBox.Items.Add("Tank");
			comboBox.Items.Add("Kot Mumin");
			comboBox.Items.Add("Tandlianwala");
			comboBox.Items.Add("Chak Azam Sahu");
			comboBox.Items.Add("Loralai");
			comboBox.Items.Add("Jalalpur Pirwala");
			comboBox.Items.Add("Pabbi");
			comboBox.Items.Add("Chak Jhumra");
			comboBox.Items.Add("Sahiwal");
			comboBox.Items.Add("Renala Khurd");
			comboBox.Items.Add("Risalpur Cantonment");
			comboBox.Items.Add("Lakki");
			comboBox.Items.Add("Topi");
			comboBox.Items.Add("Hangu");
			comboBox.Items.Add("Pir Jo Goth");
			comboBox.Items.Add("Kundian");
			comboBox.Items.Add("Pir Mahal");
			comboBox.Items.Add("Khurrianwala");
			comboBox.Items.Add("Mehrabpur");
			comboBox.Items.Add("Pindi Bhattian");
			comboBox.Items.Add("Malakwal City");
			comboBox.Items.Add("Narang Mandi");
			comboBox.Items.Add("Malakwal");
			comboBox.Items.Add("Thul");
			comboBox.Items.Add("Pindi Gheb");
			comboBox.Items.Add("Zahir Pir");
			comboBox.Items.Add("Dunyapur");
			comboBox.Items.Add("Gambat");
			comboBox.Items.Add("Kashmor");
			comboBox.Items.Add("Alipur");
			comboBox.Items.Add("Naudero");
			comboBox.Items.Add("Pasni");
			comboBox.Items.Add("Sukheke Mandi");
			comboBox.Items.Add("Setharja Old");
			comboBox.Items.Add("Khewra");
			comboBox.Items.Add("Mamu Kanjan");
			comboBox.Items.Add("Sharqpur Sharif");
			comboBox.Items.Add("Digri");
			comboBox.Items.Add("Bhera");
			comboBox.Items.Add("Sakrand");
			comboBox.Items.Add("Tando Jam");
			comboBox.Items.Add("Raiwind");
			comboBox.Items.Add("Lalian");
			comboBox.Items.Add("Khairpur Tamewah");
			comboBox.Items.Add("Kharan");
			comboBox.Items.Add("Mehar");
			comboBox.Items.Add("Khangah Dogran");
			comboBox.Items.Add("Khairpur Nathan Shah");
			comboBox.Items.Add("Upper Dir");
			comboBox.Items.Add("Ghauspur");
			comboBox.Items.Add("Tangi");
			comboBox.Items.Add("Utmanzai");
			comboBox.Items.Add("Thal");
			comboBox.Items.Add("Minchianabad");
			comboBox.Items.Add("Garh Maharaja");
			comboBox.Items.Add("Jahanian Shah");
			comboBox.Items.Add("Mastung");
			comboBox.Items.Add("Mananwala");
			comboBox.Items.Add("Fazilpur");
			comboBox.Items.Add("Talamba");
			comboBox.Items.Add("Kunjah");
			comboBox.Items.Add("Jhawarian");
			comboBox.Items.Add("Nasirabad");
			comboBox.Items.Add("Nushki");
			comboBox.Items.Add("Sita Road");
			comboBox.Items.Add("Dijkot");
			comboBox.Items.Add("Sillanwali");
			comboBox.Items.Add("Kandiaro");
			comboBox.Items.Add("Zaida");
			comboBox.Items.Add("Kunri");
			comboBox.Items.Add("Kalat");
			comboBox.Items.Add("Daud Khel");
			comboBox.Items.Add("Mitha Tiwana");
			comboBox.Items.Add("Hazro City");
			comboBox.Items.Add("Dunga Bunga");
			comboBox.Items.Add("Aman Garh");
			comboBox.Items.Add("Karor");
			comboBox.Items.Add("Kot Diji");
			comboBox.Items.Add("Kalur Kot");
			comboBox.Items.Add("Murree");
			comboBox.Items.Add("Faqirwali");
			comboBox.Items.Add("Ahmadpur Sial");
			comboBox.Items.Add("Phalia");
			comboBox.Items.Add("Yazman");
			comboBox.Items.Add("Raja Jang");
			comboBox.Items.Add("Chak Five Hundred Seventy-five");
			comboBox.Items.Add("Pishin");
			comboBox.Items.Add("Chak One Hundred Twenty Nine Left");
			comboBox.Items.Add("Chawinda");
			comboBox.Items.Add("Ubauro");
			comboBox.Items.Add("Mithi");
			comboBox.Items.Add("Akora");
			comboBox.Items.Add("Zafarwal");
			comboBox.Items.Add("Kot Samaba");
			comboBox.Items.Add("Eminabad");
			comboBox.Items.Add("Kahuta");
			comboBox.Items.Add("Ranipur");
			comboBox.Items.Add("Kulachi");
			comboBox.Items.Add("Khanpur Mahar");
			comboBox.Items.Add("Hingorja");
			comboBox.Items.Add("Naukot");
			comboBox.Items.Add("Pind Dadan Khan");
			comboBox.Items.Add("Kanganpur");
			comboBox.Items.Add("Faruka");
			comboBox.Items.Add("Kotli Loharan");
			comboBox.Items.Add("Shahpur Chakar");
			comboBox.Items.Add("Talhar");
			comboBox.Items.Add("Pad Idan");
			comboBox.Items.Add("Kot Ghulam Muhammad");
			comboBox.Items.Add("Qadirpur Ran");
			comboBox.Items.Add("Bela");
			comboBox.Items.Add("Surkhpur");
			comboBox.Items.Add("Dhoro Naro");
			comboBox.Items.Add("Khangarh");
			comboBox.Items.Add("Sarai Naurang");
			comboBox.Items.Add("Gharo");
			comboBox.Items.Add("Bhit Shah");
			comboBox.Items.Add("Matiari");
			comboBox.Items.Add("Dhanot");
			comboBox.Items.Add("Warah");
			comboBox.Items.Add("Lachi");
			comboBox.Items.Add("Baddomalhi");
			comboBox.Items.Add("Jand");
			comboBox.Items.Add("Chak Two Hundred Forty-nine Thal Development Authority");
			comboBox.Items.Add("Dera Bugti");
			comboBox.Items.Add("Tharu Shah");
			comboBox.Items.Add("Naushahro Firoz");
			comboBox.Items.Add("Dajal");
			comboBox.Items.Add("Daur");
			comboBox.Items.Add("Bhopalwala");
			comboBox.Items.Add("Paharpur");
			comboBox.Items.Add("Bhan");
			comboBox.Items.Add("Mach");
			comboBox.Items.Add("Goth Radhan");
			comboBox.Items.Add("Uthal");
			comboBox.Items.Add("Kaleke Mandi");
			comboBox.Items.Add("Jiwani");
			comboBox.Items.Add("Johi");
			comboBox.Items.Add("Chhor");
			comboBox.Items.Add("Mangla");
			comboBox.Items.Add("Bhawana");
			comboBox.Items.Add("Shahr Sultan");
			comboBox.Items.Add("Jhol");
			comboBox.Items.Add("Sodhri");
			comboBox.Items.Add("Kalabagh");
			comboBox.Items.Add("Sinjhoro");
			comboBox.Items.Add("Kamar Mushani");
			comboBox.Items.Add("Kallar Kahar");
			comboBox.Items.Add("Chuhar Jamali");
			comboBox.Items.Add("Harnoli");
			comboBox.Items.Add("Sarai Sidhu");
			comboBox.Items.Add("Choa Saidan Shah");
			comboBox.Items.Add("Dadhar");
			comboBox.Items.Add("Darya Khan");
			comboBox.Items.Add("Daira Din Panah");
			comboBox.Items.Add("Garhiyasin");
			comboBox.Items.Add("Madeji");
			comboBox.Items.Add("Dokri");
			comboBox.Items.Add("Sobhodero");
			comboBox.Items.Add("Dalbandin");
			comboBox.Items.Add("Daulatpur");
			comboBox.Items.Add("Bhag");
			comboBox.Items.Add("Rasulnagar");
			comboBox.Items.Add("Chak");
			comboBox.Items.Add("Shahpur");
			comboBox.Items.Add("Tando Bago");
			comboBox.Items.Add("Baffa");
			comboBox.Items.Add("Karak");
			comboBox.Items.Add("Garhi Khairo");
			comboBox.Items.Add("Lakhi");
			comboBox.Items.Add("Gadani");
			comboBox.Items.Add("Surab");
			comboBox.Items.Add("Rojhan");
			comboBox.Items.Add("Ormara");
			comboBox.Items.Add("Chamber");
			comboBox.Items.Add("Kalaswala");
			comboBox.Items.Add("Islamkot");
			comboBox.Items.Add("Liliani");
			comboBox.Items.Add("Bhiria");
			comboBox.Items.Add("Mirwah Gorchani");
			comboBox.Items.Add("Dhaunkal");
			comboBox.Items.Add("Daultala");
			comboBox.Items.Add("Diplo");
			comboBox.Items.Add("Kohlu");
			comboBox.Items.Add("Harnai");
			comboBox.Items.Add("Jandiala Sher Khan");
			comboBox.Items.Add("Daromehar");
			comboBox.Items.Add("Mankera");
			comboBox.Items.Add("Sanjwal");
			comboBox.Items.Add("Miro Khan");
			comboBox.Items.Add("Gilgit");
			comboBox.Items.Add("Kot Sultan");
			comboBox.Items.Add("Khadro");
			comboBox.Items.Add("Berani");
			comboBox.Items.Add("Begowala");
			comboBox.Items.Add("Tangwani");
			comboBox.Items.Add("Bozdar Wada");
			comboBox.Items.Add("Jati");
			comboBox.Items.Add("Rustam");
			comboBox.Items.Add("Darya Khan Marri");
			comboBox.Items.Add("Sohbatpur");
			comboBox.Items.Add("Doaba");
			comboBox.Items.Add("Mirpur Bhtoro");
			comboBox.Items.Add("Sann");
			comboBox.Items.Add("Samaro");
			comboBox.Items.Add("Barkhan");
			comboBox.Items.Add("Bandhi");
			comboBox.Items.Add("Karaundi");
			comboBox.Items.Add("Mirpur Sakro");
			comboBox.Items.Add("Adilpur");
			comboBox.Items.Add("Bagarji");
			comboBox.Items.Add("Goth Phulji");
			comboBox.Items.Add("Rajo Khanani");
			comboBox.Items.Add("Alik Ghund");
			comboBox.Items.Add("Dinan Bashnoian Wala");
			comboBox.Items.Add("Jam Sahib");
			comboBox.Items.Add("Kandiari");
			comboBox.Items.Add("Kadhan");
			comboBox.Items.Add("Goth Garelo");
			comboBox.Items.Add("Nazir Town");
			comboBox.Items.Add("Khadan Khak");
			comboBox.Items.Add("Pithoro");
			comboBox.Items.Add("Duki");
			comboBox.Items.Add("Nabisar");
			comboBox.Items.Add("Kario Ghanwar");
			comboBox.Items.Add("Parachina");
		}

		public static void Karachi(ComboBox comboBox)
		{
			comboBox.Items.Add("AIRPORT");
			comboBox.Items.Add("BALDIA TOWN");
			comboBox.Items.Add("BOARD OF SECONDARY EDUCATION");
			comboBox.Items.Add("CANTT");
			comboBox.Items.Add("CITY GPO");
			comboBox.Items.Add("CLIFTON");
			comboBox.Items.Add("COD");
			comboBox.Items.Add("DARUL-ULOOM");
			comboBox.Items.Add("DEFENCE SOCIETY");
			comboBox.Items.Add("EXPORT PROCESSING ZONE");
			comboBox.Items.Add("FEDERAL B AREA");
			comboBox.Items.Add("GULSHAN-E-IQBAL");
			comboBox.Items.Add("HABIB BANK");
			comboBox.Items.Add("HOTEL METROPOLE");
			comboBox.Items.Add("JINNAH POST GRADUATE MEDICAL CENTER");
			comboBox.Items.Add("KARACHI GPO");
			comboBox.Items.Add("KARACHI UNIVERSITY");
			comboBox.Items.Add("KEEMARI");
			comboBox.Items.Add("KORANGI CREEK");
			comboBox.Items.Add("KORANGI GPO");
			comboBox.Items.Add("LANDHI COLONY");
			comboBox.Items.Add("LIAQATABAD");
			comboBox.Items.Add("LIYARI");
			comboBox.Items.Add("MALIR CANTT");
			comboBox.Items.Add("MALIR CITY");
			comboBox.Items.Add("MANGHOPIR");
			comboBox.Items.Add("MANORA");
			comboBox.Items.Add("MARIPUR(CE)");
			comboBox.Items.Add("MARIPUR(FA)");
			comboBox.Items.Add("MEHMOODABAD");
			comboBox.Items.Add("MODEL COLONY");
			comboBox.Items.Add("MURAD MEMON GOTH");
			comboBox.Items.Add("NATIONAL CEMENT INDUSTRY (DALMIA)");
			comboBox.Items.Add("NAZIMABAD GPO");
			comboBox.Items.Add("NEW KARACHI");
			comboBox.Items.Add("NEW TOWN GPO");
			comboBox.Items.Add("NORTH NAZIMABAD GPO");
			comboBox.Items.Add("ORANGE TOWN");
			comboBox.Items.Add("P.C.S.I.R");
			comboBox.Items.Add("P.E.C.H.S");
			comboBox.Items.Add("PAKISTAN MACHINE TOOL FACTORY");
			comboBox.Items.Add("PAKISTAN NAVAL ARMAMENT DEPOT");
			comboBox.Items.Add("PAKISTAN STEEL MILLS");
			comboBox.Items.Add("PAKISTAN STEEL MILLS TOWN SHIP");
			comboBox.Items.Add("PORT MUHAMMAD BIN QASIM");
			comboBox.Items.Add("QUAIDABAD");
			comboBox.Items.Add("RAFA-E-AAM SOCIETY");
			comboBox.Items.Add("S.I.T.E");
			comboBox.Items.Add("SADDAR GPO");
			comboBox.Items.Add("SHAH FAISAL COLONY");
			comboBox.Items.Add("SHAHRA-E-FAISAL");
			comboBox.Items.Add("SHER SHAH COLONY");
			comboBox.Items.Add("SINDH GOVERNOR HOUSE");
			comboBox.Items.Add("NISHTER ROAD");
		}

		public static bool isValid(TextBox textBox1, DateTimePicker dateTimePicker1, ComboBox comboBox1, ComboBox comboBox2, ComboBox comboBox4, ComboBox comboBox3, TextBox textBox2, RadioButton radioButton1, RadioButton radioButton2)
		{
			if (textBox1.Text.Trim() == string.Empty)
			{
				MessageBox.Show("Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textBox1.Focus();
				return false;
			}

			DateTime currentDate = DateTime.Now;
			var getDate = dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
			DateTime dob = DateTime.Parse(getDate);
			DateTime getOnlyDate = dob.Date;

			var year = 365.25 * 10;
			var a = (currentDate - getOnlyDate).Days;

			if (a < year)
			{
				MessageBox.Show("You should 10 years old", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				dateTimePicker1.Focus();
				return false;
			}

			if (comboBox1.SelectedItem == null)
			{
				MessageBox.Show("Height is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
				comboBox1.Focus();
				return false;
			}

			if (comboBox2.SelectedItem == null)
			{
				MessageBox.Show("Bloodgroup is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
				comboBox2.Focus();
				return false;
			}

			if (comboBox4.SelectedItem == null)
			{
				MessageBox.Show("Qualification is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
				comboBox4.Focus();
				return false;
			}

			if (comboBox3.SelectedItem == null)
			{
				MessageBox.Show("City is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
				comboBox3.Focus();
				return false;
			}

			if (textBox2.Text == "")
			{
				MessageBox.Show("Postral Code is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
				textBox2.Focus();
				return false;
			}

			if (!(radioButton1.Checked || radioButton2.Checked))
			{
				MessageBox.Show("Gender is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}
	}
}
