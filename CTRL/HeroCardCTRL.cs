using Godot;
using System;

public class HeroCardCTRL : Control
{
	private Control Hero { get; set; }
	private Button NovoHeroi { get; set; }
	private Slider Nivel { get; set; }
	private Slider Equipamento { get; set; }
	private Slider Maldicao { get; set; }
	private Label Poder { get; set; }
	private Label NivelTexto { get; set; }
	private Label EquipamentoTexto { get; set; }
	private Label MaldicaoTexto { get; set; }
	public override void _Ready()
	{
		Hero = GetNode<Control>("./Heroi");
		Nivel = GetNode<Slider>("./Heroi/VBoxContainer/Nivel/NivelSlider");
		Equipamento = GetNode<Slider>("./Heroi/VBoxContainer/Equipamento/NivelEquip");
		Maldicao = GetNode<Slider>("./Heroi/VBoxContainer/Maldicao/NivelMaldicao");
		Poder = GetNode<Label>("./Heroi/VBoxContainer/Poder/Valor");
		NivelTexto = GetNode<Label>("./Heroi/VBoxContainer/Nivel/Valor");
		EquipamentoTexto = GetNode<Label>("./Heroi/VBoxContainer/Equipamento/Valor");
		MaldicaoTexto = GetNode<Label>("./Heroi/VBoxContainer/Maldicao/Valor");
		CalcularPoder();
	}
	private void _on_NivelSlider_value_changed(float value)
	{
		CalcularPoder();
	}
	private void _on_NivelEquip_value_changed(float value)
	{
		CalcularPoder();
	}
	private void _on_NivelMaldicao_value_changed(float value)
	{
		CalcularPoder();
	}
	private void _on_Button_button_up()
	{
		Hero.Visible = false;
		CalcularPoder();
	}
	private void _on_ButtonNovo_button_up()
	{
		Hero.Visible = true;
		CalcularPoder();
	}
	private void CalcularPoder()
	{
		NivelTexto.Text = Nivel.Value.ToString();
		EquipamentoTexto.Text = Equipamento.Value.ToString();
		MaldicaoTexto.Text = Maldicao.Value.ToString();
		Poder.Text = (Nivel.Value + Equipamento.Value + Maldicao.Value).ToString();
	}
}
