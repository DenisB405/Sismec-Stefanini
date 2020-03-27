import { Instituicao } from '../Instituicao';

export class instituicaoResponse {
    currentPage: number;
    firstPage: number;
    lastPage: number;
    allPage : number[];
    listaRegistros: Instituicao[];
}