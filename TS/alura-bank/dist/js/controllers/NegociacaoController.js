import { Negociacao } from "../models/Negociação.js";
export class NegociacaoController {
    constructor() {
        this.inputData = document.querySelector('[data-date]');
        this.inputQuantidade = document.querySelector('[data-quantidade]');
        this.inputValor = document.querySelector('[data-valor]');
    }
    adiciona() {
        const negociacao = this.criaNegociacao();
        console.log(negociacao);
        this.limparFormulario();
    }
    criaNegociacao() {
        const exp = /-/g;
        const date = new Date(this.inputData.value.replace(exp, ','));
        const quantidade = parseInt(this.inputQuantidade.value);
        const valor = parseFloat(this.inputValor.value);
        return new Negociacao(date, quantidade, valor);
    }
    limparFormulario() {
        this.inputData.value = "";
        this.inputQuantidade.value = "";
        this.inputValor.value = "";
        this.inputData.focus();
    }
}
