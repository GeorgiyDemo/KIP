#pragma once

namespace Test {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: добавьте код конструктора
			//
		}
	protected:
		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Button^  button1;
	protected:

	private:
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(115, 73);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(58, 13);
			this->label1->TabIndex = 0;
			this->label1->Text = L"Нет снега";
			this->label1->Click += gcnew System::EventHandler(this, &MyForm::label1_Click);
			this->label1->MouseHover += gcnew System::EventHandler(this, &MyForm::label1_MouseHover);
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(69, 134);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(142, 50);
			this->button1->TabIndex = 1;
			this->button1->Text = L"Нажми меня";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(279, 264);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->label1);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			this->Load += gcnew System::EventHandler(this, &MyForm::MyForm_Load);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void label1_Click(System::Object^  sender, System::EventArgs^  e) {
	}
	
	//Кликаем на Button1
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
		MessageBox::Show("Очень  плохо!");
	}
	
	//Зависаем на label1 мышкой
	private: System::Void label1_MouseHover(System::Object^  sender, System::EventArgs^  e) {
		MessageBox::Show("Событие Hover!");
	}
	private: System::Void MyForm_Load(System::Object^  sender, System::EventArgs^  e) {
		label1->Text = "Нет снега";
		button1->Text = "Нажми меня";
	}
	};
}
