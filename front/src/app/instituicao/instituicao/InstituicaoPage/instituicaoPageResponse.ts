import { Instituicao } from '../Instituicao';

export class instituicaoResponse {
    currentPage: number;
    totalPages: number;
    quantidadeTotal: number;
    listaRegistros: Instituicao[];
}