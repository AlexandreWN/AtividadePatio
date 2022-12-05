import {Carros} from './Carros';
import { Concessionaria } from './Concessionaria';
export interface Area{
    id : number,
    quantidade : number,
    area : number,
    concessionariaId : number,
    automoveisId : number,
    automoveis : Carros,
    concessionarias : Concessionaria,
}