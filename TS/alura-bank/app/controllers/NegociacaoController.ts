import { Negociacao } from "../models/Negociação.js";

export class NegociacaoController {
  private inputData: HTMLInputElement;
  private inputQuantidade: HTMLInputElement;
  private inputValor: HTMLInputElement;

  constructor() { 
    this.inputData = document.querySelector('[data-date]');
    this.inputQuantidade = document.querySelector('[data-quantidade]');
    this.inputValor = document.querySelector('[data-valor]');
  }

  adiciona(): void { 
    const negociacao = this.criaNegociacao();

    console.log(negociacao);
    this.limparFormulario();
  }

  criaNegociacao(): Negociacao {
    const exp = /-/g;
    const date = new Date(this.inputData.value.replace(exp, ','));
    const quantidade = parseInt(this.inputQuantidade.value);
    const valor = parseFloat(this.inputValor.value);
    return new Negociacao(date, quantidade, valor);
  }

  limparFormulario(): void {
    this.inputData.value = "";
    this.inputQuantidade.value = "";
    this.inputValor.value = "";

    this.inputData.focus();
  }
}