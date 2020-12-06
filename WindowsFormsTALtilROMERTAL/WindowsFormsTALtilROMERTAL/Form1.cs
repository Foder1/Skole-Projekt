using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTALtilROMERTAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            const string ROMAN_1 = "I";
            const string ROMAN_2 = "II";
            const string ROMAN_3 = "III";
            const string ROMAN_4 = "IV";
            const string ROMAN_5 = "V";
            const string ROMAN_6 = "VI";
            const string ROMAN_7 = "VII";
            const string ROMAN_8 = "VIII";
            const string ROMAN_9 = "IX";
            const string ROMAN_10 = "X";

            const string ROMAN_11 = "XI";
            const string ROMAN_12 = "XII";
            const string ROMAN_13 = "XIII";
            const string ROMAN_14 = "XIV";
            const string ROMAN_15 = "XV";
            const string ROMAN_16 = "XVI";
            const string ROMAN_17 = "XVII";
            const string ROMAN_18 = "XVIII";
            const string ROMAN_19 = "XIX";
            const string ROMAN_20 = "XX";

            const string ROMAN_21 = "XXI";
            const string ROMAN_22 = "XXII";
            const string ROMAN_23 = "XXIII";
            const string ROMAN_24 = "XXIV";
            const string ROMAN_25 = "XXV";
            const string ROMAN_26 = "XXVI";
            const string ROMAN_27 = "XXVII";
            const string ROMAN_28 = "XXVIII";
            const string ROMAN_29 = "XXIX";
            const string ROMAN_30 = "XXX";

            const string ROMAN_31 = "XXXI";
            const string ROMAN_32 = "XII";
            const string ROMAN_33 = "XXXIII";
            const string ROMAN_34 = "XXXIV";
            const string ROMAN_35 = "XXXV";
            const string ROMAN_36 = "XXXVI";
            const string ROMAN_37 = "XXXVII";
            const string ROMAN_38 = "XXXVIII";
            const string ROMAN_39 = "XXXIX";
            const string ROMAN_40 = "XL";

            const string ROMAN_41 = "XLI";
            const string ROMAN_42 = "XLII";
            const string ROMAN_43 = "XLIII";
            const string ROMAN_44 = "XLIV";
            const string ROMAN_45 = "XLV";
            const string ROMAN_46 = "XLVI";
            const string ROMAN_47 = "XLVII";
            const string ROMAN_48 = "XLVIII";
            const string ROMAN_49 = "XLIX";
            const string ROMAN_50 = "L";

            const string ROMAN_51 = "LI";
            const string ROMAN_52 = "LII";
            const string ROMAN_53 = "LIII";
            const string ROMAN_54 = "LIV";
            const string ROMAN_55 = "LV";
            const string ROMAN_56 = "LVI";
            const string ROMAN_57 = "LVII";
            const string ROMAN_58 = "LVIII";
            const string ROMAN_59 = "LIX";
            const string ROMAN_60 = "LX";

            const string ROMAN_61 = "LXI";
            const string ROMAN_62 = "LXII";
            const string ROMAN_63 = "LXIII";
            const string ROMAN_64 = "LXIV";
            const string ROMAN_65 = "LXV";
            const string ROMAN_66 = "LXVI";
            const string ROMAN_67 = "LXVII";
            const string ROMAN_68 = "LXVIII";
            const string ROMAN_69 = "LXIX";
            const string ROMAN_70 = "LXX";

            const string ROMAN_71 = "LXXI";
            const string ROMAN_72 = "LXXII";
            const string ROMAN_73 = "LXXIII";
            const string ROMAN_74 = "LXXIV";
            const string ROMAN_75 = "LXXV";
            const string ROMAN_76 = "LXXVI";
            const string ROMAN_77 = "LXXVII";
            const string ROMAN_78 = "LXXVIII";
            const string ROMAN_79 = "LXXIX";
            const string ROMAN_80 = "LXXX";

            const string ROMAN_81 = "LXXXI";
            const string ROMAN_82 = "LXXXII";
            const string ROMAN_83 = "LXXXIII";
            const string ROMAN_84 = "LXXXIV";
            const string ROMAN_85 = "LXXXV";
            const string ROMAN_86 = "LXXXVI";
            const string ROMAN_87 = "LXXXVII";
            const string ROMAN_88 = "LXXXVIII";
            const string ROMAN_89 = "LXXXIX";
            const string ROMAN_90 = "XC";

            const string ROMAN_91 = "XCI";
            const string ROMAN_92 = "XCII";
            const string ROMAN_93 = "XCIII";
            const string ROMAN_94 = "XCIV";
            const string ROMAN_95 = "XCV";
            const string ROMAN_96 = "XCVI";
            const string ROMAN_97 = "XCVII";
            const string ROMAN_98 = "XCVIII";
            const string ROMAN_99 = "XCIX";
            const string ROMAN_100 = "C";

            const string ROMAN_101 = "CI";
            const string ROMAN_102 = "CII";
            const string ROMAN_103 = "CIII";
            const string ROMAN_104 = "CIV";
            const string ROMAN_105 = "CV";
            const string ROMAN_106 = "CVI";
            const string ROMAN_107 = "CVII";
            const string ROMAN_108 = "CVIII";
            const string ROMAN_109 = "CIX";
            const string ROMAN_110 = "CX";

            const string ROMAN_111 = "CXI";
            const string ROMAN_112 = "CXII";
            const string ROMAN_113 = "CXIII";
            const string ROMAN_114 = "CXIV";
            const string ROMAN_115 = "CXV";
            const string ROMAN_116 = "CXVI";
            const string ROMAN_117 = "CXVII";
            const string ROMAN_118 = "CXVIII";
            const string ROMAN_119 = "CXIX";
            const string ROMAN_120 = "CXX";

            const string ROMAN_121 = "CXXI";
            const string ROMAN_122 = "CXXII";
            const string ROMAN_123 = "CXXIII";
            const string ROMAN_124 = "CXXIV";
            const string ROMAN_125 = "CXXV";
            const string ROMAN_126 = "CXXVI";
            const string ROMAN_127 = "CXXVII";
            const string ROMAN_128 = "CXXVIII";
            const string ROMAN_129 = "CXXIX";
            const string ROMAN_130 = "CXXX";

            const string ROMAN_131 = "CXXXI";
            const string ROMAN_132 = "CXII";
            const string ROMAN_133 = "CXXXIII";
            const string ROMAN_134 = "CXXXIV";
            const string ROMAN_135 = "CXXXV";
            const string ROMAN_136 = "CXXXVI";
            const string ROMAN_137 = "CXXXVII";
            const string ROMAN_138 = "CXXXVIII";
            const string ROMAN_139 = "CXXXIX";
            const string ROMAN_140 = "CXL";

            const string ROMAN_141 = "CXLI";
            const string ROMAN_142 = "CXLII";
            const string ROMAN_143 = "CXLIII";
            const string ROMAN_144 = "CXLIV";
            const string ROMAN_145 = "CXLV";
            const string ROMAN_146 = "CXLVI";
            const string ROMAN_147 = "CXLVII";
            const string ROMAN_148 = "CXLVIII";
            const string ROMAN_149 = "CXLIX";
            const string ROMAN_150 = "CL";

            const string ROMAN_151 = "CLXI";
            const string ROMAN_152 = "CLXII";
            const string ROMAN_153 = "CLXIII";
            const string ROMAN_154 = "CLXIV";
            const string ROMAN_155 = "CLXV";
            const string ROMAN_156 = "CLXVI";
            const string ROMAN_157 = "CLXVII";
            const string ROMAN_158 = "CLXVIII";
            const string ROMAN_159 = "CLXIX";
            const string ROMAN_160 = "CLX";

            const string ROMAN_161 = "CLXI";
            const string ROMAN_162 = "CLXII";
            const string ROMAN_163 = "CLXIII";
            const string ROMAN_164 = "CLXIV";
            const string ROMAN_165 = "CLXV";
            const string ROMAN_166 = "CLXVI";
            const string ROMAN_167 = "CLXVII";
            const string ROMAN_168 = "CLXVIII";
            const string ROMAN_169 = "CLXIX";
            const string ROMAN_170 = "CLXX";


            const string ROMAN_171 = "CLXXI";
            const string ROMAN_172 = "CLXXII";
            const string ROMAN_173 = "CLXXIII";
            const string ROMAN_174 = "CLXXIV";
            const string ROMAN_175 = "CLXXV";
            const string ROMAN_176 = "CLXXVI";
            const string ROMAN_177 = "CLXXVII";
            const string ROMAN_178 = "CLXXVIII";
            const string ROMAN_179 = "CLXXIX";
            const string ROMAN_180 = "CLXXX";

            const string ROMAN_181 = "CLXXXI";
            const string ROMAN_182 = "CLXXXII";
            const string ROMAN_183 = "CLXXXIII";
            const string ROMAN_184 = "CLXXXIV";
            const string ROMAN_185 = "CLXXXV";
            const string ROMAN_186 = "CLXXXVI";
            const string ROMAN_187 = "CLXXXVII";
            const string ROMAN_188 = "CLXXXVIII";
            const string ROMAN_189 = "CLXXXIX";
            const string ROMAN_190 = "CXC";

            const string ROMAN_191 = "CXCI";
            const string ROMAN_192 = "CXCII";
            const string ROMAN_193 = "CXCIII";
            const string ROMAN_194 = "CXCIV";
            const string ROMAN_195 = "CXCV";
            const string ROMAN_196 = "CXCVI";
            const string ROMAN_197 = "CXCVII";
            const string ROMAN_198 = "CXCVIII";
            const string ROMAN_199 = "CXCIX";
            const string ROMAN_200 = "CC";

            const string ROMAN_201 = "CCI";
            const string ROMAN_202 = "CCII";
            const string ROMAN_203 = "CCIII";
            const string ROMAN_204 = "CCIV";
            const string ROMAN_205 = "CCV";
            const string ROMAN_206 = "CCVI";
            const string ROMAN_207 = "CCVII";
            const string ROMAN_208 = "CCVIII";
            const string ROMAN_209 = "CCIX";
            const string ROMAN_210 = "CCX";

            const string ROMAN_211 = "CCXI";
            const string ROMAN_212 = "CCXII";
            const string ROMAN_213 = "CCXIII";
            const string ROMAN_214 = "CCXIV";
            const string ROMAN_215 = "CCXV";
            const string ROMAN_216 = "CCXVI";
            const string ROMAN_217 = "CCXVII";
            const string ROMAN_218 = "CCXVIII";
            const string ROMAN_219 = "CCXIX";
            const string ROMAN_220 = "CCXX";

            const string ROMAN_221 = "CCXXI";
            const string ROMAN_222 = "CCXXII";
            const string ROMAN_223 = "CCXXIII";
            const string ROMAN_224 = "CCXXIV";
            const string ROMAN_225 = "CCXXV";
            const string ROMAN_226 = "CCXXVI";
            const string ROMAN_227 = "CCXXVII";
            const string ROMAN_228 = "CCXXVIII";
            const string ROMAN_229 = "CCXXIX";
            const string ROMAN_230 = "CCXXX";

            const string ROMAN_231 = "CCXXXI";
            const string ROMAN_232 = "CCXII";
            const string ROMAN_233 = "CCXXXIII";
            const string ROMAN_234 = "CCXXXIV";
            const string ROMAN_235 = "CCXXXV";
            const string ROMAN_236 = "CCXXXVI";
            const string ROMAN_237 = "CCXXXVII";
            const string ROMAN_238 = "CCXXXVIII";
            const string ROMAN_239 = "CCXXXIX";
            const string ROMAN_240 = "CCXL";

            const string ROMAN_241 = "CCXLI";
            const string ROMAN_242 = "CCXLII";
            const string ROMAN_243 = "CCXLIII";
            const string ROMAN_244 = "CCXLIV";
            const string ROMAN_245 = "CCXLV";
            const string ROMAN_246 = "CCXLVI";
            const string ROMAN_247 = "CCXLVII";
            const string ROMAN_248 = "CCXLVIII";
            const string ROMAN_249 = "CCXLIX";
            const string ROMAN_250 = "CCL";

            const string ROMAN_251 = "CCLI";
            const string ROMAN_252 = "CCLII";
            const string ROMAN_253 = "CCLIII";
            const string ROMAN_254 = "CCLIV";
            const string ROMAN_255 = "CCLV";
            const string ROMAN_256 = "CCLVI";
            const string ROMAN_257 = "CCLVII";
            const string ROMAN_258 = "CCLVIII";
            const string ROMAN_259 = "CCLIX";
            const string ROMAN_260 = "CCLX";

            const string ROMAN_261 = "CCLXI";
            const string ROMAN_262 = "CCLXII";
            const string ROMAN_263 = "CCLXIII";
            const string ROMAN_264 = "CCLXIV";
            const string ROMAN_265 = "CCLXV";
            const string ROMAN_266 = "CCLXVI";
            const string ROMAN_267 = "CCLXVII";
            const string ROMAN_268 = "CCLXVIII";
            const string ROMAN_269 = "CCLXIX";
            const string ROMAN_270 = "CCLXX";

            const string ROMAN_271 = "CCLXXI";
            const string ROMAN_272 = "CCLXXII";
            const string ROMAN_273 = "CCLXXIII";
            const string ROMAN_274 = "CCLXXIV";
            const string ROMAN_275 = "CCLXXV";
            const string ROMAN_276 = "CCLXXVI";
            const string ROMAN_277 = "CCLXXVII";
            const string ROMAN_278 = "CCLXXVIII";
            const string ROMAN_279 = "CCLXXIX";
            const string ROMAN_280 = "CCLXXX";

            const string ROMAN_281 = "CCLXXXI";
            const string ROMAN_282 = "CCLXXXII";
            const string ROMAN_283 = "CCLXXXIII";
            const string ROMAN_284 = "CCLXXXIV";
            const string ROMAN_285 = "CCLXXXV";
            const string ROMAN_286 = "CCLXXXVI";
            const string ROMAN_287 = "CCLXXXVII";
            const string ROMAN_288 = "CCLXXXVIII";
            const string ROMAN_289 = "CCLXXXIX";
            const string ROMAN_290 = "CCXC";

            const string ROMAN_291 = "CCXCI";
            const string ROMAN_292 = "CCXCII";
            const string ROMAN_293 = "CCXCIII";
            const string ROMAN_294 = "CCXCIV";
            const string ROMAN_295 = "CCXCV";
            const string ROMAN_296 = "CCXCVI";
            const string ROMAN_297 = "CCXCVII";
            const string ROMAN_298 = "CCXCVIII";
            const string ROMAN_299 = "CCXCIX";
            const string ROMAN_300 = "CCC";

            const string ROMAN_301 = "CCCI";
            const string ROMAN_302 = "CCCII";
            const string ROMAN_303 = "CCCIII";
            const string ROMAN_304 = "CCCIV";
            const string ROMAN_305 = "CCCV";
            const string ROMAN_306 = "CCCVI";
            const string ROMAN_307 = "CCCVII";
            const string ROMAN_308 = "CCCVIII";
            const string ROMAN_309 = "CCCIX";
            const string ROMAN_310 = "CCCX";

            const string ROMAN_311 = "CCCXI";
            const string ROMAN_312 = "CCCXII";
            const string ROMAN_313 = "CCCXIII";
            const string ROMAN_314 = "CCCXIV";
            const string ROMAN_315 = "CCCXV";
            const string ROMAN_316 = "CCCXVI";
            const string ROMAN_317 = "CCCXVII";
            const string ROMAN_318 = "CCCXVIII";
            const string ROMAN_319 = "CCCXIX";
            const string ROMAN_320 = "CCCXX";

            const string ROMAN_321 = "CCCXXI";
            const string ROMAN_322 = "CCCXXII";
            const string ROMAN_323 = "CCCXXIII";
            const string ROMAN_324 = "CCCXXIV";
            const string ROMAN_325 = "CCCXXV";
            const string ROMAN_326 = "CCCXXVI";
            const string ROMAN_327 = "CCCXXVII";
            const string ROMAN_328 = "CCCXXVIII";
            const string ROMAN_329 = "CCCXXIX";
            const string ROMAN_330 = "CCCXXX";

            const string ROMAN_331 = "CCCXXXI";
            const string ROMAN_332 = "CCCXII";
            const string ROMAN_333 = "CCCXXXIII";
            const string ROMAN_334 = "CCCXXXIV";
            const string ROMAN_335 = "CCCXXXV";
            const string ROMAN_336 = "CCCXXXVI";
            const string ROMAN_337 = "CCCXXXVII";
            const string ROMAN_338 = "CCCXXXVIII";
            const string ROMAN_339 = "CCCXXXIX";
            const string ROMAN_340 = "CCCXL";

            const string ROMAN_341 = "CCCXLI";
            const string ROMAN_342 = "CCCXLII";
            const string ROMAN_343 = "CCCXLIII";
            const string ROMAN_344 = "CCCXLIV";
            const string ROMAN_345 = "CCCXLV";
            const string ROMAN_346 = "CCCXLVI";
            const string ROMAN_347 = "CCCXLVII";
            const string ROMAN_348 = "CCCXLVIII";
            const string ROMAN_349 = "CCCXLIX";
            const string ROMAN_350 = "CCCL";

            const string ROMAN_351 = "CCCLI";
            const string ROMAN_352 = "CCCLII";
            const string ROMAN_353 = "CCCLIII";
            const string ROMAN_354 = "CCCLIV";
            const string ROMAN_355 = "CCCLV";
            const string ROMAN_356 = "CCCLVI";
            const string ROMAN_357 = "CCCLVII";
            const string ROMAN_358 = "CCCLVIII";
            const string ROMAN_359 = "CCCLIX";
            const string ROMAN_360 = "CCCLX";

            const string ROMAN_361 = "CCCLXI";
            const string ROMAN_362 = "CCCLXII";
            const string ROMAN_363 = "CCCLXIII";
            const string ROMAN_364 = "CCCLXIV";
            const string ROMAN_365 = "CCCLXV";
            const string ROMAN_366 = "CCCLXVI";
            const string ROMAN_367 = "CCCLXVII";
            const string ROMAN_368 = "CCCLXVIII";
            const string ROMAN_369 = "CCCLXIX";
            const string ROMAN_370 = "CCCLXX";


            const string ROMAN_371 = "CCCLXXI";
            const string ROMAN_372 = "CCCLXXII";
            const string ROMAN_373 = "CCCLXXIII";
            const string ROMAN_374 = "CCCLXXIV";
            const string ROMAN_375 = "CCCLXXV";
            const string ROMAN_376 = "CCCLXXVI";
            const string ROMAN_377 = "CCCLXXVII";
            const string ROMAN_378 = "CCCLXXVIII";
            const string ROMAN_379 = "CCCLXXIX";
            const string ROMAN_380 = "CCCLXXX";

            const string ROMAN_381 = "CCCLXXXI";
            const string ROMAN_382 = "CCCLXXXII";
            const string ROMAN_383 = "CCCLXXXIII";
            const string ROMAN_384 = "CCCLXXXIV";
            const string ROMAN_385 = "CCCLXXXV";
            const string ROMAN_386 = "CCCLXXXVI";
            const string ROMAN_387 = "CCCLXXXVII";
            const string ROMAN_388 = "CCCLXXXVIII";
            const string ROMAN_389 = "CCCLXXXIX";
            const string ROMAN_390 = "CCCXC";

            const string ROMAN_391 = "CCCXCI";
            const string ROMAN_392 = "CCCXCII";
            const string ROMAN_393 = "CCCXCIII";
            const string ROMAN_394 = "CCCXCIV";
            const string ROMAN_395 = "CCCXCV";
            const string ROMAN_396 = "CCCXCVI";
            const string ROMAN_397 = "CCCXCVII";
            const string ROMAN_398 = "CCCXCVIII";
            const string ROMAN_399 = "CCCXCIX";
            const string ROMAN_400 = "CD";

            const string ROMAN_401 = "CDI";
            const string ROMAN_402 = "CDII";
            const string ROMAN_403 = "CDIII";
            const string ROMAN_404 = "CDIV";
            const string ROMAN_405 = "CDV";
            const string ROMAN_406 = "CDVI";
            const string ROMAN_407 = "CDVII";
            const string ROMAN_408 = "CDVIII";
            const string ROMAN_409 = "CDIX";
            const string ROMAN_410 = "CDX";

            const string ROMAN_411 = "CDXI";
            const string ROMAN_412 = "CDXII";
            const string ROMAN_413 = "CDXIII";
            const string ROMAN_414 = "CDXIV";
            const string ROMAN_415 = "CDXV";
            const string ROMAN_416 = "CDXVI";
            const string ROMAN_417 = "CDXVII";
            const string ROMAN_418 = "CDXVIII";
            const string ROMAN_419 = "CDXIX";
            const string ROMAN_420 = "CDXX";

            const string ROMAN_421 = "CDXXI";
            const string ROMAN_422 = "CDXXII";
            const string ROMAN_423 = "CDXXIII";
            const string ROMAN_424 = "CDXXIV";
            const string ROMAN_425 = "CDXXV";
            const string ROMAN_426 = "CDXXVI";
            const string ROMAN_427 = "CDXXVII";
            const string ROMAN_428 = "CDXXVIII";
            const string ROMAN_429 = "CDXXIX";
            const string ROMAN_430 = "CDXXX";

            const string ROMAN_431 = "CDXXXI";
            const string ROMAN_432 = "CDXII";
            const string ROMAN_433 = "CDXXXIII";
            const string ROMAN_434 = "CDXXXIV";
            const string ROMAN_435 = "CDXXXV";
            const string ROMAN_436 = "CDXXXVI";
            const string ROMAN_437 = "CDXXXVII";
            const string ROMAN_438 = "CDXXXVIII";
            const string ROMAN_439 = "CDXXXIX";
            const string ROMAN_440 = "CDXL";

            const string ROMAN_441 = "CDXLI";
            const string ROMAN_442 = "CDXLII";
            const string ROMAN_443 = "CDXLIII";
            const string ROMAN_444 = "CDXLIV";
            const string ROMAN_445 = "CDXLV";
            const string ROMAN_446 = "CDXLVI";
            const string ROMAN_447 = "CDXLVII";
            const string ROMAN_448 = "CDXLVIII";
            const string ROMAN_449 = "CDXLIX";
            const string ROMAN_450 = "CDL";

            const string ROMAN_451 = "CDLI";
            const string ROMAN_452 = "CDLII";
            const string ROMAN_453 = "CDLIII";
            const string ROMAN_454 = "CDLIV";
            const string ROMAN_455 = "CDLV";
            const string ROMAN_456 = "CDLVI";
            const string ROMAN_457 = "CDLVII";
            const string ROMAN_458 = "CDLVIII";
            const string ROMAN_459 = "CDLIX";
            const string ROMAN_460 = "CDLX";

            const string ROMAN_461 = "CDLXI";
            const string ROMAN_462 = "CDLXII";
            const string ROMAN_463 = "CDLXIII";
            const string ROMAN_464 = "CDLXIV";
            const string ROMAN_465 = "CDLXV";
            const string ROMAN_466 = "CDLXVI";
            const string ROMAN_467 = "CDLXVII";
            const string ROMAN_468 = "CDLXVIII";
            const string ROMAN_469 = "CDLXIX";
            const string ROMAN_470 = "CDLXX";

            const string ROMAN_471 = "CDLXXI";
            const string ROMAN_472 = "CDLXXII";
            const string ROMAN_473 = "CDLXXIII";
            const string ROMAN_474 = "CDLXXIV";
            const string ROMAN_475 = "CDLXXV";
            const string ROMAN_476 = "CDLXXVI";
            const string ROMAN_477 = "CDLXXVII";
            const string ROMAN_478 = "CDLXXVIII";
            const string ROMAN_479 = "CDLXXIX";
            const string ROMAN_480 = "CDLXXX";

            const string ROMAN_481 = "CDLXXXI";
            const string ROMAN_482 = "CDLXXXII";
            const string ROMAN_483 = "CDLXXXIII";
            const string ROMAN_484 = "CDLXXXIV";
            const string ROMAN_485 = "CDLXXXV";
            const string ROMAN_486 = "CDLXXXVI";
            const string ROMAN_487 = "CDLXXXVII";
            const string ROMAN_488 = "CDLXXXVIII";
            const string ROMAN_489 = "CDLXXXIX";
            const string ROMAN_490 = "CDXC";

            const string ROMAN_491 = "CDXCI";
            const string ROMAN_492 = "CDXCII";
            const string ROMAN_493 = "CDXCIII";
            const string ROMAN_494 = "CDXCIV";
            const string ROMAN_495 = "CDXCV";
            const string ROMAN_496 = "CDXCVI";
            const string ROMAN_497 = "CDXCVII";
            const string ROMAN_498 = "CDXCVIII";
            const string ROMAN_499 = "CDXCIX";
            const string ROMAN_500 = "D";

            const string ROMAN_501 = "DI";
            const string ROMAN_502 = "DII";
            const string ROMAN_503 = "DIII";
            const string ROMAN_504 = "DIV";
            const string ROMAN_505 = "DV";
            const string ROMAN_506 = "DVI";
            const string ROMAN_507 = "DVII";
            const string ROMAN_508 = "DVIII";
            const string ROMAN_509 = "DIX";
            const string ROMAN_510 = "DX";

            const string ROMAN_511 = "DXI";
            const string ROMAN_512 = "DXII";
            const string ROMAN_513 = "DXIII";
            const string ROMAN_514 = "DXIV";
            const string ROMAN_515 = "DXV";
            const string ROMAN_516 = "DXVI";
            const string ROMAN_517 = "DXVII";
            const string ROMAN_518 = "DXVIII";
            const string ROMAN_519 = "DXIX";
            const string ROMAN_520 = "DXX";

            const string ROMAN_521 = "DXXI";
            const string ROMAN_522 = "DXXII";
            const string ROMAN_523 = "DXXIII";
            const string ROMAN_524 = "DXXIV";
            const string ROMAN_525 = "DXXV";
            const string ROMAN_526 = "DXXVI";
            const string ROMAN_527 = "DXXVII";
            const string ROMAN_528 = "DXXVIII";
            const string ROMAN_529 = "DXXIX";
            const string ROMAN_530 = "DXXX";

            const string ROMAN_531 = "DXXXI";
            const string ROMAN_532 = "DXII";
            const string ROMAN_533 = "DXXXIII";
            const string ROMAN_534 = "DXXXIV";
            const string ROMAN_535 = "DXXXV";
            const string ROMAN_536 = "DXXXVI";
            const string ROMAN_537 = "DXXXVII";
            const string ROMAN_538 = "DXXXVIII";
            const string ROMAN_539 = "DXXXIX";
            const string ROMAN_540 = "DXL";

            const string ROMAN_541 = "DXLI";
            const string ROMAN_542 = "DXLII";
            const string ROMAN_543 = "DXLIII";
            const string ROMAN_544 = "DXLIV";
            const string ROMAN_545 = "DXLV";
            const string ROMAN_546 = "DXLVI";
            const string ROMAN_547 = "DXLVII";
            const string ROMAN_548 = "DXLVIII";
            const string ROMAN_549 = "DXLIX";
            const string ROMAN_550 = "DL";

            const string ROMAN_551 = "DLI";
            const string ROMAN_552 = "DLII";
            const string ROMAN_553 = "DLIII";
            const string ROMAN_554 = "DLIV";
            const string ROMAN_555 = "DLV";
            const string ROMAN_556 = "DLVI";
            const string ROMAN_557 = "DLVII";
            const string ROMAN_558 = "DLVIII";
            const string ROMAN_559 = "DLIX";
            const string ROMAN_560 = "DLX";

            const string ROMAN_561 = "DLXI";
            const string ROMAN_562 = "DLXII";
            const string ROMAN_563 = "DLXIII";
            const string ROMAN_564 = "DLXIV";
            const string ROMAN_565 = "DLXV";
            const string ROMAN_566 = "DLXVI";
            const string ROMAN_567 = "DLXVII";
            const string ROMAN_568 = "DLXVIII";
            const string ROMAN_569 = "DLXIX";
            const string ROMAN_570 = "DLXX";


            const string ROMAN_571 = "DLXXI";
            const string ROMAN_572 = "DLXXII";
            const string ROMAN_573 = "DLXXIII";
            const string ROMAN_574 = "DLXXIV";
            const string ROMAN_575 = "DLXXV";
            const string ROMAN_576 = "DLXXVI";
            const string ROMAN_577 = "DLXXVII";
            const string ROMAN_578 = "DLXXVIII";
            const string ROMAN_579 = "DLXXIX";
            const string ROMAN_580 = "DLXXX";

            const string ROMAN_581 = "DLXXXI";
            const string ROMAN_582 = "DLXXXII";
            const string ROMAN_583 = "DLXXXIII";
            const string ROMAN_584 = "DLXXXIV";
            const string ROMAN_585 = "DLXXXV";
            const string ROMAN_586 = "DLXXXVI";
            const string ROMAN_587 = "DLXXXVII";
            const string ROMAN_588 = "DLXXXVIII";
            const string ROMAN_589 = "DLXXXIX";
            const string ROMAN_590 = "DXC";

            const string ROMAN_591 = "DXCI";
            const string ROMAN_592 = "DXCII";
            const string ROMAN_593 = "DXCIII";
            const string ROMAN_594 = "DXCIV";
            const string ROMAN_595 = "DXCV";
            const string ROMAN_596 = "DXCVI";
            const string ROMAN_597 = "DXCVII";
            const string ROMAN_598 = "DXCVIII";
            const string ROMAN_599 = "DXCIX";
            const string ROMAN_600 = "DC";

            const string ROMAN_601 = "DCI";
            const string ROMAN_602 = "DCII";
            const string ROMAN_603 = "DCIII";
            const string ROMAN_604 = "DCIV";
            const string ROMAN_605 = "DCV";
            const string ROMAN_606 = "DCVI";
            const string ROMAN_607 = "DCVII";
            const string ROMAN_608 = "DCVIII";
            const string ROMAN_609 = "DCIX";
            const string ROMAN_610 = "DCX";

            const string ROMAN_611 = "DCXI";
            const string ROMAN_612 = "DCXII";
            const string ROMAN_613 = "DCXIII";
            const string ROMAN_614 = "DCXIV";
            const string ROMAN_615 = "DCXV";
            const string ROMAN_616 = "DCXVI";
            const string ROMAN_617 = "DCXVII";
            const string ROMAN_618 = "DCXVIII";
            const string ROMAN_619 = "DCXIX";
            const string ROMAN_620 = "DCXX";

            const string ROMAN_621 = "DCXXI";
            const string ROMAN_622 = "DCXXII";
            const string ROMAN_623 = "DCXXIII";
            const string ROMAN_624 = "DCXXIV";
            const string ROMAN_625 = "DCXXV";
            const string ROMAN_626 = "DCXXVI";
            const string ROMAN_627 = "DCXXVII";
            const string ROMAN_628 = "DCXXVIII";
            const string ROMAN_629 = "DCXXIX";
            const string ROMAN_630 = "DCXXX";

            const string ROMAN_631 = "DCXXXI";
            const string ROMAN_632 = "DCXII";
            const string ROMAN_633 = "DCXXXIII";
            const string ROMAN_634 = "DCXXXIV";
            const string ROMAN_635 = "DCXXXV";
            const string ROMAN_636 = "DCXXXVI";
            const string ROMAN_637 = "DCXXXVII";
            const string ROMAN_638 = "DCXXXVIII";
            const string ROMAN_639 = "DCXXXIX";
            const string ROMAN_640 = "DCXL";

            const string ROMAN_641 = "DCXLI";
            const string ROMAN_642 = "DCXLII";
            const string ROMAN_643 = "DCXLIII";
            const string ROMAN_644 = "DCXLIV";
            const string ROMAN_645 = "DCXLV";
            const string ROMAN_646 = "DCXLVI";
            const string ROMAN_647 = "DCXLVII";
            const string ROMAN_648 = "DCXLVIII";
            const string ROMAN_649 = "DCXLIX";
            const string ROMAN_650 = "DCL";

            const string ROMAN_651 = "DCLI";
            const string ROMAN_652 = "DCLII";
            const string ROMAN_653 = "DCLIII";
            const string ROMAN_654 = "DCLIV";
            const string ROMAN_655 = "DCLV";
            const string ROMAN_656 = "DCLVI";
            const string ROMAN_657 = "DCLVII";
            const string ROMAN_658 = "DCLVIII";
            const string ROMAN_659 = "DCLIX";
            const string ROMAN_660 = "DCLX";

            const string ROMAN_661 = "DCLXI";
            const string ROMAN_662 = "DCLXII";
            const string ROMAN_663 = "DCLXIII";
            const string ROMAN_664 = "DCLXIV";
            const string ROMAN_665 = "DCLXV";
            const string ROMAN_666 = "DCLXVI";
            const string ROMAN_667 = "DCLXVII";
            const string ROMAN_668 = "DCLXVIII";
            const string ROMAN_669 = "DCLXIX";
            const string ROMAN_670 = "DCLXX";

            const string ROMAN_671 = "DCLXXI";
            const string ROMAN_672 = "DCLXXII";
            const string ROMAN_673 = "DCLXXIII";
            const string ROMAN_674 = "DCLXXIV";
            const string ROMAN_675 = "DCLXXV";
            const string ROMAN_676 = "DCLXXVI";
            const string ROMAN_677 = "DCLXXVII";
            const string ROMAN_678 = "DCLXXVIII";
            const string ROMAN_679 = "DCLXXIX";
            const string ROMAN_680 = "DCLXXX";

            const string ROMAN_681 = "DCLXXXI";
            const string ROMAN_682 = "DCLXXXII";
            const string ROMAN_683 = "DCLXXXIII";
            const string ROMAN_684 = "DCLXXXIV";
            const string ROMAN_685 = "DCLXXXV";
            const string ROMAN_686 = "DCLXXXVI";
            const string ROMAN_687 = "DCLXXXVII";
            const string ROMAN_688 = "DCLXXXVIII";
            const string ROMAN_689 = "DCLXXXIX";
            const string ROMAN_690 = "DCXC";

            const string ROMAN_691 = "DCXCI";
            const string ROMAN_692 = "DCXCII";
            const string ROMAN_693 = "DCXCIII";
            const string ROMAN_694 = "DCXCIV";
            const string ROMAN_695 = "DCXCV";
            const string ROMAN_696 = "DCXCVI";
            const string ROMAN_697 = "DCXCVII";
            const string ROMAN_698 = "DCXCVIII";
            const string ROMAN_699 = "DCXCIX";
            const string ROMAN_700 = "DCC";

            const string ROMAN_701 = "DCCI";
            const string ROMAN_702 = "DCCII";
            const string ROMAN_703 = "DCCIII";
            const string ROMAN_704 = "DCCIV";
            const string ROMAN_705 = "DCCV";
            const string ROMAN_706 = "DCCVI";
            const string ROMAN_707 = "DCCVII";
            const string ROMAN_708 = "DCCVIII";
            const string ROMAN_709 = "DCCIX";
            const string ROMAN_710 = "DCCX";

            const string ROMAN_711 = "DCCXI";
            const string ROMAN_712 = "DCCXII";
            const string ROMAN_713 = "DCCXIII";
            const string ROMAN_714 = "DCCXIV";
            const string ROMAN_715 = "DCCXV";
            const string ROMAN_716 = "DCCXVI";
            const string ROMAN_717 = "DCCXVII";
            const string ROMAN_718 = "DCCXVIII";
            const string ROMAN_719 = "DCCXIX";
            const string ROMAN_720 = "DCCXX";

            const string ROMAN_721 = "DCCXXI";
            const string ROMAN_722 = "DCCXXII";
            const string ROMAN_723 = "DCCXXIII";
            const string ROMAN_724 = "DCCXXIV";
            const string ROMAN_725 = "DCCXXV";
            const string ROMAN_726 = "DCCXXVI";
            const string ROMAN_727 = "DCCXXVII";
            const string ROMAN_728 = "DCCXXVIII";
            const string ROMAN_729 = "DCCXXIX";
            const string ROMAN_730 = "DCCXXX";

            const string ROMAN_731 = "DCCXXXI";
            const string ROMAN_732 = "DCCXII";
            const string ROMAN_733 = "DCCXXXIII";
            const string ROMAN_734 = "DCCXXXIV";
            const string ROMAN_735 = "DCCXXXV";
            const string ROMAN_736 = "DCCXXXVI";
            const string ROMAN_737 = "DCCXXXVII";
            const string ROMAN_738 = "DCCXXXVIII";
            const string ROMAN_739 = "DCCXXXIX";
            const string ROMAN_740 = "DCCXL";

            const string ROMAN_741 = "DCCXLI";
            const string ROMAN_742 = "DCCXLII";
            const string ROMAN_743 = "DCCXLIII";
            const string ROMAN_744 = "DCCXLIV";
            const string ROMAN_745 = "DCCXLV";
            const string ROMAN_746 = "DCCXLVI";
            const string ROMAN_747 = "DCCXLVII";
            const string ROMAN_748 = "DCCXLVIII";
            const string ROMAN_749 = "DCCXLIX";
            const string ROMAN_750 = "DCCL";

            const string ROMAN_751 = "DCCLI";
            const string ROMAN_752 = "DCCLII";
            const string ROMAN_753 = "DCCLIII";
            const string ROMAN_754 = "DCCLIV";
            const string ROMAN_755 = "DCCLV";
            const string ROMAN_756 = "DCCLVI";
            const string ROMAN_757 = "DCCLVII";
            const string ROMAN_758 = "DCCLVIII";
            const string ROMAN_759 = "DCCLIX";
            const string ROMAN_760 = "DCCLX";

            const string ROMAN_761 = "DCCLXI";
            const string ROMAN_762 = "DCCLXII";
            const string ROMAN_763 = "DCCLXIII";
            const string ROMAN_764 = "DCCLXIV";
            const string ROMAN_765 = "DCCLXV";
            const string ROMAN_766 = "DCCLXVI";
            const string ROMAN_767 = "DCCLXVII";
            const string ROMAN_768 = "DCCLXVIII";
            const string ROMAN_769 = "DCCLXIX";
            const string ROMAN_770 = "DCCLXX";


            const string ROMAN_771 = "DCCLXXI";
            const string ROMAN_772 = "DCCLXXII";
            const string ROMAN_773 = "DCCLXXIII";
            const string ROMAN_774 = "DCCLXXIV";
            const string ROMAN_775 = "DCCLXXV";
            const string ROMAN_776 = "DCCLXXVI";
            const string ROMAN_777 = "DCCLXXVII";
            const string ROMAN_778 = "DCCLXXVIII";
            const string ROMAN_779 = "DCCLXXIX";
            const string ROMAN_780 = "DCCLXXX";

            const string ROMAN_781 = "DCCLXXXI";
            const string ROMAN_782 = "DCCLXXXII";
            const string ROMAN_783 = "DCCLXXXIII";
            const string ROMAN_784 = "DCCLXXXIV";
            const string ROMAN_785 = "DCCLXXXV";
            const string ROMAN_786 = "DCCLXXXVI";
            const string ROMAN_787 = "DCCLXXXVII";
            const string ROMAN_788 = "DCCLXXXVIII";
            const string ROMAN_789 = "DCCLXXXIX";
            const string ROMAN_790 = "DCCXC";

            const string ROMAN_791 = "DCCXCI";
            const string ROMAN_792 = "DCCXCII";
            const string ROMAN_793 = "DCCXCIII";
            const string ROMAN_794 = "DCCXCIV";
            const string ROMAN_795 = "DCCXCV";
            const string ROMAN_796 = "DCCXCVI";
            const string ROMAN_797 = "DCCXCVII";
            const string ROMAN_798 = "DCCXCVIII";
            const string ROMAN_799 = "DCCXCIX";
            const string ROMAN_800 = "DCCC";

            const string ROMAN_801 = "DCCCI";
            const string ROMAN_802 = "DCCCII";
            const string ROMAN_803 = "DCCCIII";
            const string ROMAN_804 = "DCCCIV";
            const string ROMAN_805 = "DCCCV";
            const string ROMAN_806 = "DCCCVI";
            const string ROMAN_807 = "DCCCVII";
            const string ROMAN_808 = "DCCCVIII";
            const string ROMAN_809 = "DCCCIX";
            const string ROMAN_810 = "DCCCX";

            const string ROMAN_811 = "DCCCXI";
            const string ROMAN_812 = "DCCCXII";
            const string ROMAN_813 = "DCCCXIII";
            const string ROMAN_814 = "DCCCXIV";
            const string ROMAN_815 = "DCCCXV";
            const string ROMAN_816 = "DCCCXVI";
            const string ROMAN_817 = "DCCCXVII";
            const string ROMAN_818 = "DCCCXVIII";
            const string ROMAN_819 = "DCCCXIX";
            const string ROMAN_820 = "DCCCXX";

            const string ROMAN_821 = "DCCCXXI";
            const string ROMAN_822 = "DCCCXXII";
            const string ROMAN_823 = "DCCCXXIII";
            const string ROMAN_824 = "DCCCXXIV";
            const string ROMAN_825 = "DCCCXXV";
            const string ROMAN_826 = "DCCCXXVI";
            const string ROMAN_827 = "DCCCXXVII";
            const string ROMAN_828 = "DCCCXXVIII";
            const string ROMAN_829 = "DCCCXXIX";
            const string ROMAN_830 = "DCCCXXX";

            const string ROMAN_831 = "DCCCXXXI";
            const string ROMAN_832 = "DCCCXII";
            const string ROMAN_833 = "DCCCXXXIII";
            const string ROMAN_834 = "DCCCXXXIV";
            const string ROMAN_835 = "DCCCXXXV";
            const string ROMAN_836 = "DCCCXXXVI";
            const string ROMAN_837 = "DCCCXXXVII";
            const string ROMAN_838 = "DCCCXXXVIII";
            const string ROMAN_839 = "DCCCXXXIX";
            const string ROMAN_840 = "DCCCXL";

            const string ROMAN_841 = "DCCCXLI";
            const string ROMAN_842 = "DCCCXLII";
            const string ROMAN_843 = "DCCCXLIII";
            const string ROMAN_844 = "DCCCXLIV";
            const string ROMAN_845 = "DCCCXLV";
            const string ROMAN_846 = "DCCCXLVI";
            const string ROMAN_847 = "DCCCXLVII";
            const string ROMAN_848 = "DCCCXLVIII";
            const string ROMAN_849 = "DCCCXLIX";
            const string ROMAN_850 = "DCCCL";

            const string ROMAN_851 = "DCCCLI";
            const string ROMAN_852 = "DCCCLII";
            const string ROMAN_853 = "DCCCLIII";
            const string ROMAN_854 = "DCCCLIV";
            const string ROMAN_855 = "DCCCLV";
            const string ROMAN_856 = "DCCCLVI";
            const string ROMAN_857 = "DCCCLVII";
            const string ROMAN_858 = "DCCCLVIII";
            const string ROMAN_859 = "DCCCLIX";
            const string ROMAN_860 = "DCCCLX";

            const string ROMAN_861 = "DCCCLXI";
            const string ROMAN_862 = "VLXII";
            const string ROMAN_863 = "DCCCLXIII";
            const string ROMAN_864 = "DCCCLXIV";
            const string ROMAN_865 = "DCCCLXV";
            const string ROMAN_866 = "VLXVI";
            const string ROMAN_867 = "DCCCLXVII";
            const string ROMAN_868 = "DCCCLXVIII";
            const string ROMAN_869 = "DCCCLXIX";
            const string ROMAN_870 = "DCCCLXX";

            const string ROMAN_871 = "DCCCLXXI";
            const string ROMAN_872 = "DCCCLXXII";
            const string ROMAN_873 = "DCCCLXXIII";
            const string ROMAN_874 = "DCCCLXXIV";
            const string ROMAN_875 = "DCCCLXXV";
            const string ROMAN_876 = "DCCCLXXVI";
            const string ROMAN_877 = "DCCCLXXVII";
            const string ROMAN_878 = "DCCCLXXVIII";
            const string ROMAN_879 = "DCCCLXXIX";
            const string ROMAN_880 = "DCCCLXXX";

            const string ROMAN_881 = "DCCCLXXXI";
            const string ROMAN_882 = "DCCCLXXXII";
            const string ROMAN_883 = "DCCCLXXXIII";
            const string ROMAN_884 = "DCCCLXXXIV";
            const string ROMAN_885 = "DCCCLXXXV";
            const string ROMAN_886 = "DCCCLXXXVI";
            const string ROMAN_887 = "DCCCLXXXVII";
            const string ROMAN_888 = "DCCCLXXXVIII";
            const string ROMAN_889 = "DCCCLXXXIX";
            const string ROMAN_890 = "DCCCXC";

            const string ROMAN_891 = "DCCCXCI";
            const string ROMAN_892 = "DCCCXCII";
            const string ROMAN_893 = "DCCCXCIII";
            const string ROMAN_894 = "DCCCXCIV";
            const string ROMAN_895 = "DCCCXCV";
            const string ROMAN_896 = "DCCCXCVI";
            const string ROMAN_897 = "DCCCXCVII";
            const string ROMAN_898 = "DCCCXCVIII";
            const string ROMAN_899 = "DCCCXCIX";
            const string ROMAN_900 = "CM";

            const string ROMAN_901 = "CMI";
            const string ROMAN_902 = "CMII";
            const string ROMAN_903 = "CMIII";
            const string ROMAN_904 = "CMIV";
            const string ROMAN_905 = "CMV";
            const string ROMAN_906 = "CMVI";
            const string ROMAN_907 = "CMVII";
            const string ROMAN_908 = "CMVIII";
            const string ROMAN_909 = "CMIX";
            const string ROMAN_910 = "CMX";

            const string ROMAN_911 = "CMXI";
            const string ROMAN_912 = "CMXII";
            const string ROMAN_913 = "CMXIII";
            const string ROMAN_914 = "CMXIV";
            const string ROMAN_915 = "CMXV";
            const string ROMAN_916 = "CMXVI";
            const string ROMAN_917 = "CMXVII";
            const string ROMAN_918 = "CMXVIII";
            const string ROMAN_919 = "CMXIX";
            const string ROMAN_920 = "CMXX";

            const string ROMAN_921 = "CMXXI";
            const string ROMAN_922 = "CMXXII";
            const string ROMAN_923 = "CMXXIII";
            const string ROMAN_924 = "CMXXIV";
            const string ROMAN_925 = "CMXXV";
            const string ROMAN_926 = "CMXXVI";
            const string ROMAN_927 = "CMXXVII";
            const string ROMAN_928 = "CMXXVIII";
            const string ROMAN_929 = "CMXXIX";
            const string ROMAN_930 = "CMXXX";

            const string ROMAN_931 = "CMXXXI";
            const string ROMAN_932 = "CMXII";
            const string ROMAN_933 = "CMXXXIII";
            const string ROMAN_934 = "CMXXXIV";
            const string ROMAN_935 = "CMXXXV";
            const string ROMAN_936 = "CMXXXVI";
            const string ROMAN_937 = "CMXXXVII";
            const string ROMAN_938 = "CMXXXVIII";
            const string ROMAN_939 = "CMXXXIX";
            const string ROMAN_940 = "CMXL";

            const string ROMAN_941 = "CMXLI";
            const string ROMAN_942 = "CMXLII";
            const string ROMAN_943 = "CMXLIII";
            const string ROMAN_944 = "CMXLIV";
            const string ROMAN_945 = "CMXLV";
            const string ROMAN_946 = "CMXLVI";
            const string ROMAN_947 = "CMXLVII";
            const string ROMAN_948 = "CMXLVIII";
            const string ROMAN_949 = "CMXLIX";
            const string ROMAN_950 = "CML";

            const string ROMAN_951 = "CMLI";
            const string ROMAN_952 = "CMLII";
            const string ROMAN_953 = "CMLIII";
            const string ROMAN_954 = "CMLIV";
            const string ROMAN_955 = "CMLV";
            const string ROMAN_956 = "CMLVI";
            const string ROMAN_957 = "CMLVII";
            const string ROMAN_958 = "CMLVIII";
            const string ROMAN_959 = "CMLIX";
            const string ROMAN_960 = "CMLX";

            const string ROMAN_961 = "CMLXI";
            const string ROMAN_962 = "CMLXII";
            const string ROMAN_963 = "CMLXIII";
            const string ROMAN_964 = "CMLXIV";
            const string ROMAN_965 = "CMLXV";
            const string ROMAN_966 = "CMLXVI";
            const string ROMAN_967 = "CMLXVIII";
            const string ROMAN_968 = "CMLXVIII";
            const string ROMAN_969 = "CMLXIX";
            const string ROMAN_970 = "CMLXX";

            const string ROMAN_971 = "CMLXXI";
            const string ROMAN_972 = "CMLXXII";
            const string ROMAN_973 = "CMLXXIII";
            const string ROMAN_974 = "CMLXXIV";
            const string ROMAN_975 = "CMLXXV";
            const string ROMAN_976 = "CMLXXVI";
            const string ROMAN_977 = "CMLXXVII";
            const string ROMAN_978 = "CMLXXVIII";
            const string ROMAN_979 = "CMLXXIX";
            const string ROMAN_980 = "CMLXXX";

            const string ROMAN_981 = "CMLXXXI";
            const string ROMAN_982 = "CMLXXXII";
            const string ROMAN_983 = "CMLXXXIII";
            const string ROMAN_984 = "CMLXXXIV";
            const string ROMAN_985 = "CMLXXXV";
            const string ROMAN_986 = "CMLXXXVI";
            const string ROMAN_987 = "CMLXXXVII";
            const string ROMAN_988 = "CMLXXXVIII";
            const string ROMAN_989 = "CMLXXXIX";
            const string ROMAN_990 = "CMXC";

            const string ROMAN_991 = "CMXCI";
            const string ROMAN_992 = "CMXCII";
            const string ROMAN_993 = "CMXCIII";
            const string ROMAN_994 = "CMXCIV";
            const string ROMAN_995 = "CMXCV";
            const string ROMAN_996 = "CMXCVI";
            const string ROMAN_997 = "CMXCVII";
            const string ROMAN_998 = "CMXCVIII";
            const string ROMAN_999 = "CMXCIX";
            const string ROMAN_1000 = "M";


            const string ROMAN_1001 = "MI";
            const string ROMAN_1002 = "MII";
            const string ROMAN_1003 = "MIII";
            const string ROMAN_1004 = "MIV";
            const string ROMAN_1005 = "MV";
            const string ROMAN_1006 = "MVI";
            const string ROMAN_1007 = "MVII";
            const string ROMAN_1008 = "MVIII";
            const string ROMAN_1009 = "MIX";
            const string ROMAN_1010 = "MX";

            const string ROMAN_1011 = "MXI";
            const string ROMAN_1012 = "MXII";
            const string ROMAN_1013 = "MXIII";
            const string ROMAN_1014 = "MXIV";
            const string ROMAN_1015 = "MXV";
            const string ROMAN_1016 = "MXVI";
            const string ROMAN_1017 = "MXVII";
            const string ROMAN_1018 = "MXVIII";
            const string ROMAN_1019 = "MXIX";
            const string ROMAN_1020 = "MXX";

            const string ROMAN_1021 = "MXXI";
            const string ROMAN_1022 = "MXXII";
            const string ROMAN_1023 = "MXXIII";
            const string ROMAN_1024 = "MXXIV";
            const string ROMAN_1025 = "MXXV";
            const string ROMAN_1026 = "MXXVI";
            const string ROMAN_1027 = "MXXVII";
            const string ROMAN_1028 = "MXXVIII";
            const string ROMAN_1029 = "MXXIX";
            const string ROMAN_1030 = "MXXX";

            const string ROMAN_1031 = "MXXXI";
            const string ROMAN_1032 = "MXII";
            const string ROMAN_1033 = "MXXXIII";
            const string ROMAN_1034 = "MXXXIV";
            const string ROMAN_1035 = "MXXXV";
            const string ROMAN_1036 = "MXXXVI";
            const string ROMAN_1037 = "MXXXVII";
            const string ROMAN_1038 = "MXXXVIII";
            const string ROMAN_1039 = "MXXXIX";
            const string ROMAN_1040 = "MXL";

            const string ROMAN_1041 = "MXLI";
            const string ROMAN_1042 = "MXLII";
            const string ROMAN_1043 = "MXLIII";
            const string ROMAN_1044 = "MXLIV";
            const string ROMAN_1045 = "MXLV";
            const string ROMAN_1046 = "MXLVI";
            const string ROMAN_1047 = "MXLVII";
            const string ROMAN_1048 = "MXLVIII";
            const string ROMAN_1049 = "MXLIX";
            const string ROMAN_1050 = "ML";

            const string ROMAN_1051 = "MLI";
            const string ROMAN_1052 = "MLII";
            const string ROMAN_1053 = "MLIII";
            const string ROMAN_1054 = "MLIV";
            const string ROMAN_1055 = "MLV";
            const string ROMAN_1056 = "MLVI";
            const string ROMAN_1057 = "MLVII";
            const string ROMAN_1058 = "MLVIII";
            const string ROMAN_1059 = "MLIX";
            const string ROMAN_1060 = "MLX";

            const string ROMAN_1061 = "MLXI";
            const string ROMAN_1062 = "MLXII";
            const string ROMAN_1063 = "MLXIII";
            const string ROMAN_1064 = "MLXIV";
            const string ROMAN_1065 = "MLXV";
            const string ROMAN_1066 = "MLXVI";
            const string ROMAN_1067 = "MLXVII";
            const string ROMAN_1068 = "MLXVIII";
            const string ROMAN_1069 = "MLXIX";
            const string ROMAN_1070 = "MLXX";

            const string ROMAN_1071 = "MLXXI";
            const string ROMAN_1072 = "MLXXII";
            const string ROMAN_1073 = "MLXXIII";
            const string ROMAN_1074 = "MLXXIV";
            const string ROMAN_1075 = "MLXXV";
            const string ROMAN_1076 = "MLXXVI";
            const string ROMAN_1077 = "MLXXVII";
            const string ROMAN_1078 = "MLXXVIII";
            const string ROMAN_1079 = "MLXXIX";
            const string ROMAN_1080 = "MLXXX";

            const string ROMAN_1081 = "MLXXXI";
            const string ROMAN_1082 = "MLXXXII";
            const string ROMAN_1083 = "MLXXXIII";
            const string ROMAN_1084 = "MLXXXIV";
            const string ROMAN_1085 = "MLXXXV";
            const string ROMAN_1086 = "MLXXXVI";
            const string ROMAN_1087 = "MLXXXVII";
            const string ROMAN_1088 = "MLXXXVIII";
            const string ROMAN_1089 = "MLXXXIX";
            const string ROMAN_1090 = "MXC";

            const string ROMAN_1091 = "MXCI";
            const string ROMAN_1092 = "MXCII";
            const string ROMAN_1093 = "MXCIII";
            const string ROMAN_1094 = "MXCIV";
            const string ROMAN_1095 = "MXCV";
            const string ROMAN_1096 = "MXCVI";
            const string ROMAN_1097 = "MXCVII";
            const string ROMAN_1098 = "MXCVIII";
            const string ROMAN_1099 = "MXCIX";
            const string ROMAN_1100 = "MC";

            const string ROMAN_1101 = "MCI";
            const string ROMAN_1102 = "MCII";
            const string ROMAN_1103 = "MCIII";
            const string ROMAN_1104 = "MCIV";
            const string ROMAN_1105 = "MCV";
            const string ROMAN_1106 = "MCVI";
            const string ROMAN_1107 = "MCVII";
            const string ROMAN_1108 = "MCVIII";
            const string ROMAN_1109 = "MCIX";
            const string ROMAN_1110 = "MCX";

            const string ROMAN_1111 = "MCXI";
            const string ROMAN_1112 = "MCXII";
            const string ROMAN_1113 = "MCXIII";
            const string ROMAN_1114 = "MCXIV";
            const string ROMAN_1115 = "MCXV";
            const string ROMAN_1116 = "MCXVI";
            const string ROMAN_1117 = "MCXVII";
            const string ROMAN_1118 = "MCXVIII";
            const string ROMAN_1119 = "MCXIX";
            const string ROMAN_1120 = "MCXX";

            const string ROMAN_1121 = "MCXXI";
            const string ROMAN_1122 = "MCXXII";
            const string ROMAN_1123 = "MCXXIII";
            const string ROMAN_1124 = "MCXXIV";
            const string ROMAN_1125 = "MCXXV";
            const string ROMAN_1126 = "MCXXVI";
            const string ROMAN_1127 = "MCXXVII";
            const string ROMAN_1128 = "MCXXVIII";
            const string ROMAN_1129 = "MCXXIX";
            const string ROMAN_1130 = "MCXXX";

            const string ROMAN_1131 = "MCXXXI";
            const string ROMAN_1132 = "MCXII";
            const string ROMAN_1133 = "MCXXXIII";
            const string ROMAN_1134 = "MCXXXIV";
            const string ROMAN_1135 = "MCXXXV";
            const string ROMAN_1136 = "MCXXXVI";
            const string ROMAN_1137 = "MCXXXVII";
            const string ROMAN_1138 = "MCXXXVIII";
            const string ROMAN_1139 = "MCXXXIX";
            const string ROMAN_1140 = "MCXL";

            const string ROMAN_1141 = "MCXLI";
            const string ROMAN_1142 = "MCXLII";
            const string ROMAN_1143 = "MCXLIII";
            const string ROMAN_1144 = "MCXLIV";
            const string ROMAN_1145 = "MCXLV";
            const string ROMAN_1146 = "MCXLVI";
            const string ROMAN_1147 = "MCXLVII";
            const string ROMAN_1148 = "MCXLVIII";
            const string ROMAN_1149 = "MCXLIX";
            const string ROMAN_1150 = "MCL";

            const string ROMAN_1151 = "MCLXI";
            const string ROMAN_1152 = "MCLXII";
            const string ROMAN_1153 = "MCLXIII";
            const string ROMAN_1154 = "MCLXIV";
            const string ROMAN_1155 = "MCLXV";
            const string ROMAN_1156 = "MCLXVI";
            const string ROMAN_1157 = "MCLXVII";
            const string ROMAN_1158 = "MCLXVIII";
            const string ROMAN_1159 = "MCLXIX";
            const string ROMAN_1160 = "MCLX";

            const string ROMAN_1161 = "MCLXI";
            const string ROMAN_1162 = "MCLXII";
            const string ROMAN_1163 = "MCLXIII";
            const string ROMAN_1164 = "MCLXIV";
            const string ROMAN_1165 = "MCLXV";
            const string ROMAN_1166 = "MCLXVI";
            const string ROMAN_1167 = "MCLXVII";
            const string ROMAN_1168 = "MCLXVIII";
            const string ROMAN_1169 = "MCLXIX";
            const string ROMAN_1170 = "MCLXX";


            const string ROMAN_1171 = "MCLXXI";
            const string ROMAN_1172 = "MCLXXII";
            const string ROMAN_1173 = "MCLXXIII";
            const string ROMAN_1174 = "MCLXXIV";
            const string ROMAN_1175 = "MCLXXV";
            const string ROMAN_1176 = "MCLXXVI";
            const string ROMAN_1177 = "MCLXXVII";
            const string ROMAN_1178 = "MCLXXVIII";
            const string ROMAN_1179 = "MCLXXIX";
            const string ROMAN_1180 = "MCLXXX";

            const string ROMAN_1181 = "MCLXXXI";
            const string ROMAN_1182 = "MCLXXXII";
            const string ROMAN_1183 = "MCLXXXIII";
            const string ROMAN_1184 = "MCLXXXIV";
            const string ROMAN_1185 = "MCLXXXV";
            const string ROMAN_1186 = "MCLXXXVI";
            const string ROMAN_1187 = "MCLXXXVII";
            const string ROMAN_1188 = "MCLXXXVIII";
            const string ROMAN_1189 = "MCLXXXIX";
            const string ROMAN_1190 = "MCXC";

            const string ROMAN_1191 = "MCXCI";
            const string ROMAN_1192 = "MCXCII";
            const string ROMAN_1193 = "MCXCIII";
            const string ROMAN_1194 = "MCXCIV";
            const string ROMAN_1195 = "MCXCV";
            const string ROMAN_1196 = "MCXCVI";
            const string ROMAN_1197 = "MCXCVII";
            const string ROMAN_1198 = "MCXCVIII";
            const string ROMAN_1199 = "MCXCIX";
            const string ROMAN_1200 = "MCC";

            const string ROMAN_1201 = "MCCI";
            const string ROMAN_1202 = "MCCII";
            const string ROMAN_1203 = "MCCIII";
            const string ROMAN_1204 = "MCCIV";
            const string ROMAN_1205 = "MCCV";
            const string ROMAN_1206 = "MCCVI";
            const string ROMAN_1207 = "MCCVII";
            const string ROMAN_1208 = "MCCVIII";
            const string ROMAN_1209 = "MCCIX";
            const string ROMAN_1210 = "MCCX";

            const string ROMAN_1211 = "MCCXI";
            const string ROMAN_1212 = "MCCXII";
            const string ROMAN_1213 = "MCCXIII";
            const string ROMAN_1214 = "MCCXIV";
            const string ROMAN_1215 = "MCCXV";
            const string ROMAN_1216 = "MCCXVI";
            const string ROMAN_1217 = "MCCXVII";
            const string ROMAN_1218 = "MCCXVIII";
            const string ROMAN_1219 = "MCCXIX";
            const string ROMAN_1220 = "MCCXX";

            const string ROMAN_1221 = "MCCXXI";
            const string ROMAN_1222 = "MCCXXII";
            const string ROMAN_1223 = "MCCXXIII";
            const string ROMAN_1224 = "MCCXXIV";
            const string ROMAN_1225 = "MCCXXV";
            const string ROMAN_1226 = "MCCXXVI";
            const string ROMAN_1227 = "MCCXXVII";
            const string ROMAN_1228 = "MCCXXVIII";
            const string ROMAN_1229 = "MCCXXIX";
            const string ROMAN_1230 = "MCCXXX";

            const string ROMAN_1231 = "MCCXXXI";
            const string ROMAN_1232 = "MCCXII";
            const string ROMAN_1233 = "MCCXXXIII";
            const string ROMAN_1234 = "MCCXXXIV";
            const string ROMAN_1235 = "MCCXXXV";
            const string ROMAN_1236 = "MCCXXXVI";
            const string ROMAN_1237 = "MCCXXXVII";
            const string ROMAN_1238 = "MCCXXXVIII";
            const string ROMAN_1239 = "MCCXXXIX";
            const string ROMAN_1240 = "MCCXL";

            const string ROMAN_1241 = "MCCXLI";
            const string ROMAN_1242 = "MCCXLII";
            const string ROMAN_1243 = "MCCXLIII";
            const string ROMAN_1244 = "MCCXLIV";
            const string ROMAN_1245 = "MCCXLV";
            const string ROMAN_1246 = "MCCXLVI";
            const string ROMAN_1247 = "MCCXLVII";
            const string ROMAN_1248 = "MCCXLVIII";
            const string ROMAN_1249 = "MCCXLIX";
            const string ROMAN_1250 = "MCCL";

            const string ROMAN_1251 = "MCCLI";
            const string ROMAN_1252 = "MCCLII";
            const string ROMAN_1253 = "MCCLIII";
            const string ROMAN_1254 = "MCCLIV";
            const string ROMAN_1255 = "MCCLV";
            const string ROMAN_1256 = "MCCLVI";
            const string ROMAN_1257 = "MCCLVII";
            const string ROMAN_1258 = "MCCLVIII";
            const string ROMAN_1259 = "MCCLIX";
            const string ROMAN_1260 = "MCCLX";

            const string ROMAN_1261 = "MCCLXI";
            const string ROMAN_1262 = "MCCLXII";
            const string ROMAN_1263 = "MCCLXIII";
            const string ROMAN_1264 = "MCCLXIV";
            const string ROMAN_1265 = "MCCLXV";
            const string ROMAN_1266 = "MCCLXVI";
            const string ROMAN_1267 = "MCCLXVII";
            const string ROMAN_1268 = "MCCLXVIII";
            const string ROMAN_1269 = "MCCLXIX";
            const string ROMAN_1270 = "MCCLXX";

            const string ROMAN_1271 = "MCCLXXI";
            const string ROMAN_1272 = "MCCLXXII";
            const string ROMAN_1273 = "MCCLXXIII";
            const string ROMAN_1274 = "MCCLXXIV";
            const string ROMAN_1275 = "MCCLXXV";
            const string ROMAN_1276 = "MCCLXXVI";
            const string ROMAN_1277 = "MCCLXXVII";
            const string ROMAN_1278 = "MCCLXXVIII";
            const string ROMAN_1279 = "MCCLXXIX";
            const string ROMAN_1280 = "MCCLXXX";

            const string ROMAN_1281 = "MCCLXXXI";
            const string ROMAN_1282 = "MCCLXXXII";
            const string ROMAN_1283 = "MCCLXXXIII";
            const string ROMAN_1284 = "MCCLXXXIV";
            const string ROMAN_1285 = "MCCLXXXV";
            const string ROMAN_1286 = "MCCLXXXVI";
            const string ROMAN_1287 = "MCCLXXXVII";
            const string ROMAN_1288 = "MCCLXXXVIII";
            const string ROMAN_1289 = "MCCLXXXIX";
            const string ROMAN_1290 = "MCCXC";

            const string ROMAN_1291 = "MCCXCI";
            const string ROMAN_1292 = "MCCXCII";
            const string ROMAN_1293 = "MCCXCIII";
            const string ROMAN_1294 = "MCCXCIV";
            const string ROMAN_1295 = "MCCXCV";
            const string ROMAN_1296 = "MCCXCVI";
            const string ROMAN_1297 = "MCCXCVII";
            const string ROMAN_1298 = "MCCXCVIII";
            const string ROMAN_1299 = "MCCXCIX";
            const string ROMAN_1300 = "MCCC";

            const string ROMAN_1301 = "MCCCI";
            const string ROMAN_1302 = "MCCCII";
            const string ROMAN_1303 = "MCCCIII";
            const string ROMAN_1304 = "MCCCIV";
            const string ROMAN_1305 = "MCCCV";
            const string ROMAN_1306 = "MCCCVI";
            const string ROMAN_1307 = "MCCCVII";
            const string ROMAN_1308 = "MCCCVIII";
            const string ROMAN_1309 = "MCCCIX";
            const string ROMAN_1310 = "MCCCX";

            const string ROMAN_1311 = "MCCCXI";
            const string ROMAN_1312 = "MCCCXII";
            const string ROMAN_1313 = "MCCCXIII";
            const string ROMAN_1314 = "MCCCXIV";
            const string ROMAN_1315 = "MCCCXV";
            const string ROMAN_1316 = "MCCCXVI";
            const string ROMAN_1317 = "MCCCXVII";
            const string ROMAN_1318 = "MCCCXVIII";
            const string ROMAN_1319 = "MCCCXIX";
            const string ROMAN_1320 = "MCCCXX";

            const string ROMAN_1321 = "MCCCXXI";
            const string ROMAN_1322 = "MCCCXXII";
            const string ROMAN_1323 = "MCCCXXIII";
            const string ROMAN_1324 = "MCCCXXIV";
            const string ROMAN_1325 = "MCCCXXV";
            const string ROMAN_1326 = "MCCCXXVI";
            const string ROMAN_1327 = "MCCCXXVII";
            const string ROMAN_1328 = "MCCCXXVIII";
            const string ROMAN_1329 = "MCCCXXIX";
            const string ROMAN_1330 = "MCCCXXX";

            const string ROMAN_1331 = "MCCCXXXI";
            const string ROMAN_1332 = "MCCCXII";
            const string ROMAN_1333 = "MCCCXXXIII";
            const string ROMAN_1334 = "MCCCXXXIV";
            const string ROMAN_1335 = "MCCCXXXV";
            const string ROMAN_1336 = "MCCCXXXVI";
            const string ROMAN_1337 = "MCCCXXXVII";
            const string ROMAN_1338 = "MCCCXXXVIII";
            const string ROMAN_1339 = "MCCCXXXIX";
            const string ROMAN_1340 = "MCCCXL";

            const string ROMAN_1341 = "MCCCXLI";
            const string ROMAN_1342 = "MCCCXLII";
            const string ROMAN_1343 = "MCCCXLIII";
            const string ROMAN_1344 = "MCCCXLIV";
            const string ROMAN_1345 = "MCCCXLV";
            const string ROMAN_1346 = "MCCCXLVI";
            const string ROMAN_1347 = "MCCCXLVII";
            const string ROMAN_1348 = "MCCCXLVIII";
            const string ROMAN_1349 = "MCCCXLIX";
            const string ROMAN_1350 = "MCCCL";

            const string ROMAN_1351 = "MCCCLI";
            const string ROMAN_1352 = "MCCCLII";
            const string ROMAN_1353 = "MCCCLIII";
            const string ROMAN_1354 = "MCCCLIV";
            const string ROMAN_1355 = "MCCCLV";
            const string ROMAN_1356 = "MCCCLVI";
            const string ROMAN_1357 = "MCCCLVII";
            const string ROMAN_1358 = "MCCCLVIII";
            const string ROMAN_1359 = "MCCCLIX";
            const string ROMAN_1360 = "MCCCLX";

            const string ROMAN_1361 = "MCCCLXI";
            const string ROMAN_1362 = "MCCCLXII";
            const string ROMAN_1363 = "MCCCLXIII";
            const string ROMAN_1364 = "MCCCLXIV";
            const string ROMAN_1365 = "MCCCLXV";
            const string ROMAN_1366 = "MCCCLXVI";
            const string ROMAN_1367 = "MCCCLXVII";
            const string ROMAN_1368 = "MCCCLXVIII";
            const string ROMAN_1369 = "MCCCLXIX";
            const string ROMAN_1370 = "MCCCLXX";


            const string ROMAN_1371 = "MCCCLXXI";
            const string ROMAN_1372 = "MCCCLXXII";
            const string ROMAN_1373 = "MCCCLXXIII";
            const string ROMAN_1374 = "MCCCLXXIV";
            const string ROMAN_1375 = "MCCCLXXV";
            const string ROMAN_1376 = "MCCCLXXVI";
            const string ROMAN_1377 = "MCCCLXXVII";
            const string ROMAN_1378 = "MCCCLXXVIII";
            const string ROMAN_1379 = "MCCCLXXIX";
            const string ROMAN_1380 = "MCCCLXXX";

            const string ROMAN_1381 = "MCCCLXXXI";
            const string ROMAN_1382 = "MCCCLXXXII";
            const string ROMAN_1383 = "MCCCLXXXIII";
            const string ROMAN_1384 = "MCCCLXXXIV";
            const string ROMAN_1385 = "MCCCLXXXV";
            const string ROMAN_1386 = "MCCCLXXXVI";
            const string ROMAN_1387 = "MCCCLXXXVII";
            const string ROMAN_1388 = "MCCCLXXXVIII";
            const string ROMAN_1389 = "MCCCLXXXIX";
            const string ROMAN_1390 = "MCCCXC";

            const string ROMAN_1391 = "MCCCXCI";
            const string ROMAN_1392 = "MCCCXCII";
            const string ROMAN_1393 = "MCCCXCIII";
            const string ROMAN_1394 = "MCCCXCIV";
            const string ROMAN_1395 = "MCCCXCV";
            const string ROMAN_1396 = "MCCCXCVI";
            const string ROMAN_1397 = "MCCCXCVII";
            const string ROMAN_1398 = "MCCCXCVIII";
            const string ROMAN_1399 = "MCCCXCIX";
            const string ROMAN_1400 = "MCD";

            const string ROMAN_1401 = "MCDI";
            const string ROMAN_1402 = "MCDII";
            const string ROMAN_1403 = "MCDIII";
            const string ROMAN_1404 = "MCDIV";
            const string ROMAN_1405 = "MCDV";
            const string ROMAN_1406 = "MCDVI";
            const string ROMAN_1407 = "MCDVII";
            const string ROMAN_1408 = "MCDVIII";
            const string ROMAN_1409 = "MCDIX";
            const string ROMAN_1410 = "MCDX";

            const string ROMAN_1411 = "MCDXI";
            const string ROMAN_1412 = "MCDXII";
            const string ROMAN_1413 = "MCDXIII";
            const string ROMAN_1414 = "MCDXIV";
            const string ROMAN_1415 = "MCDXV";
            const string ROMAN_1416 = "MCDXVI";
            const string ROMAN_1417 = "MCDXVII";
            const string ROMAN_1418 = "MCDXVIII";
            const string ROMAN_1419 = "MCDXIX";
            const string ROMAN_1420 = "MCDXX";

            const string ROMAN_1421 = "MCDXXI";
            const string ROMAN_1422 = "MCDXXII";
            const string ROMAN_1423 = "MCDXXIII";
            const string ROMAN_1424 = "MCDXXIV";
            const string ROMAN_1425 = "MCDXXV";
            const string ROMAN_1426 = "MCDXXVI";
            const string ROMAN_1427 = "MCDXXVII";
            const string ROMAN_1428 = "MCDXXVIII";
            const string ROMAN_1429 = "MCDXXIX";
            const string ROMAN_1430 = "MCDXXX";

            const string ROMAN_1431 = "MCDXXXI";
            const string ROMAN_1432 = "MCDXII";
            const string ROMAN_1433 = "MCDXXXIII";
            const string ROMAN_1434 = "MCDXXXIV";
            const string ROMAN_1435 = "MCDXXXV";
            const string ROMAN_1436 = "MCDXXXVI";
            const string ROMAN_1437 = "MCDXXXVII";
            const string ROMAN_1438 = "MCDXXXVIII";
            const string ROMAN_1439 = "MCDXXXIX";
            const string ROMAN_1440 = "MCDXL";

            const string ROMAN_1441 = "MCDXLI";
            const string ROMAN_1442 = "MCDXLII";
            const string ROMAN_1443 = "MCDXLIII";
            const string ROMAN_1444 = "MCDXLIV";
            const string ROMAN_1445 = "MCDXLV";
            const string ROMAN_1446 = "MCDXLVI";
            const string ROMAN_1447 = "MCDXLVII";
            const string ROMAN_1448 = "MCDXLVIII";
            const string ROMAN_1449 = "MCDXLIX";
            const string ROMAN_1450 = "MCDL";

            const string ROMAN_1451 = "MCDLI";
            const string ROMAN_1452 = "MCDLII";
            const string ROMAN_1453 = "MCDLIII";
            const string ROMAN_1454 = "MCDLIV";
            const string ROMAN_1455 = "MCDLV";
            const string ROMAN_1456 = "MCDLVI";
            const string ROMAN_1457 = "MCDLVII";
            const string ROMAN_1458 = "MCDLVIII";
            const string ROMAN_1459 = "MCDLIX";
            const string ROMAN_1460 = "MCDLX";

            const string ROMAN_1461 = "MCDLXI";
            const string ROMAN_1462 = "MCDLXII";
            const string ROMAN_1463 = "MCDLXIII";
            const string ROMAN_1464 = "MCDLXIV";
            const string ROMAN_1465 = "MCDLXV";
            const string ROMAN_1466 = "MCDLXVI";
            const string ROMAN_1467 = "MCDLXVII";
            const string ROMAN_1468 = "MCDLXVIII";
            const string ROMAN_1469 = "MCDLXIX";
            const string ROMAN_1470 = "MCDLXX";

            const string ROMAN_1471 = "MCDLXXI";
            const string ROMAN_1472 = "MCDLXXII";
            const string ROMAN_1473 = "MCDLXXIII";
            const string ROMAN_1474 = "MCDLXXIV";
            const string ROMAN_1475 = "MCDLXXV";
            const string ROMAN_1476 = "MCDLXXVI";
            const string ROMAN_1477 = "MCDLXXVII";
            const string ROMAN_1478 = "MCDLXXVIII";
            const string ROMAN_1479 = "MCDLXXIX";
            const string ROMAN_1480 = "MCDLXXX";

            const string ROMAN_1481 = "MCDLXXXI";
            const string ROMAN_1482 = "MCDLXXXII";
            const string ROMAN_1483 = "MCDLXXXIII";
            const string ROMAN_1484 = "MCDLXXXIV";
            const string ROMAN_1485 = "MCDLXXXV";
            const string ROMAN_1486 = "MCDLXXXVI";
            const string ROMAN_1487 = "MCDLXXXVII";
            const string ROMAN_1488 = "MCDLXXXVIII";
            const string ROMAN_1489 = "MCDLXXXIX";
            const string ROMAN_1490 = "MCDXC";

            const string ROMAN_1491 = "MCDXCI";
            const string ROMAN_1492 = "MCDXCII";
            const string ROMAN_1493 = "MCDXCIII";
            const string ROMAN_1494 = "MCDXCIV";
            const string ROMAN_1495 = "MCDXCV";
            const string ROMAN_1496 = "MCDXCVI";
            const string ROMAN_1497 = "MCDXCVII";
            const string ROMAN_1498 = "MCDXCVIII";
            const string ROMAN_1499 = "MCDXCIX";
            const string ROMAN_1500 = "MD";

            const string ROMAN_1501 = "MDI";
            const string ROMAN_1502 = "MDII";
            const string ROMAN_1503 = "MDIII";
            const string ROMAN_1504 = "MDIV";
            const string ROMAN_1505 = "MDV";
            const string ROMAN_1506 = "MDVI";
            const string ROMAN_1507 = "MDVII";
            const string ROMAN_1508 = "MDVIII";
            const string ROMAN_1509 = "MDIX";
            const string ROMAN_1510 = "MDX";

            const string ROMAN_1511 = "MDXI";
            const string ROMAN_1512 = "MDXII";
            const string ROMAN_1513 = "MDXIII";
            const string ROMAN_1514 = "MDXIV";
            const string ROMAN_1515 = "MDXV";
            const string ROMAN_1516 = "MDXVI";
            const string ROMAN_1517 = "MDXVII";
            const string ROMAN_1518 = "MDXVIII";
            const string ROMAN_1519 = "MDXIX";
            const string ROMAN_1520 = "MDXX";

            const string ROMAN_1521 = "MDXXI";
            const string ROMAN_1522 = "MDXXII";
            const string ROMAN_1523 = "MDXXIII";
            const string ROMAN_1524 = "MDXXIV";
            const string ROMAN_1525 = "MDXXV";
            const string ROMAN_1526 = "MDXXVI";
            const string ROMAN_1527 = "MDXXVII";
            const string ROMAN_1528 = "MDXXVIII";
            const string ROMAN_1529 = "MDXXIX";
            const string ROMAN_1530 = "MDXXX";

            const string ROMAN_1531 = "MDXXXI";
            const string ROMAN_1532 = "MDXII";
            const string ROMAN_1533 = "MDXXXIII";
            const string ROMAN_1534 = "MDXXXIV";
            const string ROMAN_1535 = "MDXXXV";
            const string ROMAN_1536 = "MDXXXVI";
            const string ROMAN_1537 = "MDXXXVII";
            const string ROMAN_1538 = "MDXXXVIII";
            const string ROMAN_1539 = "MDXXXIX";
            const string ROMAN_1540 = "MDXL";

            const string ROMAN_1541 = "MDXLI";
            const string ROMAN_1542 = "MDXLII";
            const string ROMAN_1543 = "MDXLIII";
            const string ROMAN_1544 = "MDXLIV";
            const string ROMAN_1545 = "MDXLV";
            const string ROMAN_1546 = "MDXLVI";
            const string ROMAN_1547 = "MDXLVII";
            const string ROMAN_1548 = "MDXLVIII";
            const string ROMAN_1549 = "MDXLIX";
            const string ROMAN_1550 = "MDL";

            const string ROMAN_1551 = "MDLI";
            const string ROMAN_1552 = "MDLII";
            const string ROMAN_1553 = "MDLIII";
            const string ROMAN_1554 = "MDLIV";
            const string ROMAN_1555 = "MDLV";
            const string ROMAN_1556 = "MDLVI";
            const string ROMAN_1557 = "MDLVII";
            const string ROMAN_1558 = "MDLVIII";
            const string ROMAN_1559 = "MDLIX";
            const string ROMAN_1560 = "MDLX";

            const string ROMAN_1561 = "MDLXI";
            const string ROMAN_1562 = "MDLXII";
            const string ROMAN_1563 = "MDLXIII";
            const string ROMAN_1564 = "MDLXIV";
            const string ROMAN_1565 = "MDLXV";
            const string ROMAN_1566 = "MDLXVI";
            const string ROMAN_1567 = "MDLXVII";
            const string ROMAN_1568 = "MDLXVIII";
            const string ROMAN_1569 = "MDLXIX";
            const string ROMAN_1570 = "MDLXX";


            const string ROMAN_1571 = "MDLXXI";
            const string ROMAN_1572 = "MDLXXII";
            const string ROMAN_1573 = "MDLXXIII";
            const string ROMAN_1574 = "MDLXXIV";
            const string ROMAN_1575 = "MDLXXV";
            const string ROMAN_1576 = "MDLXXVI";
            const string ROMAN_1577 = "MDLXXVII";
            const string ROMAN_1578 = "MDLXXVIII";
            const string ROMAN_1579 = "MDLXXIX";
            const string ROMAN_1580 = "MDLXXX";

            const string ROMAN_1581 = "MDLXXXI";
            const string ROMAN_1582 = "MDLXXXII";
            const string ROMAN_1583 = "MDLXXXIII";
            const string ROMAN_1584 = "MDLXXXIV";
            const string ROMAN_1585 = "MDLXXXV";
            const string ROMAN_1586 = "MDLXXXVI";
            const string ROMAN_1587 = "MDLXXXVII";
            const string ROMAN_1588 = "MDLXXXVIII";
            const string ROMAN_1589 = "MDLXXXIX";
            const string ROMAN_1590 = "MDXC";

            const string ROMAN_1591 = "MDXCI";
            const string ROMAN_1592 = "MDXCII";
            const string ROMAN_1593 = "MDXCIII";
            const string ROMAN_1594 = "MDXCIV";
            const string ROMAN_1595 = "MDXCV";
            const string ROMAN_1596 = "MDXCVI";
            const string ROMAN_1597 = "MDXCVII";
            const string ROMAN_1598 = "MDXCVIII";
            const string ROMAN_1599 = "MDXCIX";
            const string ROMAN_1600 = "MDC";

            const string ROMAN_1601 = "MDCI";
            const string ROMAN_1602 = "MDCII";
            const string ROMAN_1603 = "MDCIII";
            const string ROMAN_1604 = "MDCIV";
            const string ROMAN_1605 = "MDCV";
            const string ROMAN_1606 = "MDCVI";
            const string ROMAN_1607 = "MDCVII";
            const string ROMAN_1608 = "MDCVIII";
            const string ROMAN_1609 = "MDCIX";
            const string ROMAN_1610 = "MDCX";

            const string ROMAN_1611 = "MDCXI";
            const string ROMAN_1612 = "MDCXII";
            const string ROMAN_1613 = "MDCXIII";
            const string ROMAN_1614 = "MDCXIV";
            const string ROMAN_1615 = "MDCXV";
            const string ROMAN_1616 = "MDCXVI";
            const string ROMAN_1617 = "MDCXVII";
            const string ROMAN_1618 = "MDCXVIII";
            const string ROMAN_1619 = "MDCXIX";
            const string ROMAN_1620 = "MDCXX";

            const string ROMAN_1621 = "MDCXXI";
            const string ROMAN_1622 = "MDCXXII";
            const string ROMAN_1623 = "MDCXXIII";
            const string ROMAN_1624 = "MDCXXIV";
            const string ROMAN_1625 = "MDCXXV";
            const string ROMAN_1626 = "MDCXXVI";
            const string ROMAN_1627 = "MDCXXVII";
            const string ROMAN_1628 = "MDCXXVIII";
            const string ROMAN_1629 = "MDCXXIX";
            const string ROMAN_1630 = "MDCXXX";

            const string ROMAN_1631 = "MDCXXXI";
            const string ROMAN_1632 = "MDCXII";
            const string ROMAN_1633 = "MDCXXXIII";
            const string ROMAN_1634 = "MDCXXXIV";
            const string ROMAN_1635 = "MDCXXXV";
            const string ROMAN_1636 = "MDCXXXVI";
            const string ROMAN_1637 = "MDCXXXVII";
            const string ROMAN_1638 = "MDCXXXVIII";
            const string ROMAN_1639 = "MDCXXXIX";
            const string ROMAN_1640 = "MDCXL";

            const string ROMAN_1641 = "MDCXLI";
            const string ROMAN_1642 = "MDCXLII";
            const string ROMAN_1643 = "MDCXLIII";
            const string ROMAN_1644 = "MDCXLIV";
            const string ROMAN_1645 = "MDCXLV";
            const string ROMAN_1646 = "MDCXLVI";
            const string ROMAN_1647 = "MDCXLVII";
            const string ROMAN_1648 = "MDCXLVIII";
            const string ROMAN_1649 = "MDCXLIX";
            const string ROMAN_1650 = "MDCL";

            const string ROMAN_1651 = "MDCLI";
            const string ROMAN_1652 = "MDCLII";
            const string ROMAN_1653 = "MDCLIII";
            const string ROMAN_1654 = "MDCLIV";
            const string ROMAN_1655 = "MDCLV";
            const string ROMAN_1656 = "MDCLVI";
            const string ROMAN_1657 = "MDCLVII";
            const string ROMAN_1658 = "MDCLVIII";
            const string ROMAN_1659 = "MDCLIX";
            const string ROMAN_1660 = "MDCLX";

            const string ROMAN_1661 = "MDCLXI";
            const string ROMAN_1662 = "MDCLXII";
            const string ROMAN_1663 = "MDCLXIII";
            const string ROMAN_1664 = "MDCLXIV";
            const string ROMAN_1665 = "MDCLXV";
            const string ROMAN_1666 = "MDCLXVI";
            const string ROMAN_1667 = "MDCLXVII";
            const string ROMAN_1668 = "MDCLXVIII";
            const string ROMAN_1669 = "MDCLXIX";
            const string ROMAN_1670 = "MDCLXX";

            const string ROMAN_1671 = "MDCLXXI";
            const string ROMAN_1672 = "MDCLXXII";
            const string ROMAN_1673 = "MDCLXXIII";
            const string ROMAN_1674 = "MDCLXXIV";
            const string ROMAN_1675 = "MDCLXXV";
            const string ROMAN_1676 = "MDCLXXVI";
            const string ROMAN_1677 = "MDCLXXVII";
            const string ROMAN_1678 = "MDCLXXVIII";
            const string ROMAN_1679 = "MDCLXXIX";
            const string ROMAN_1680 = "MDCLXXX";

            const string ROMAN_1681 = "MDCLXXXI";
            const string ROMAN_1682 = "MDCLXXXII";
            const string ROMAN_1683 = "MDCLXXXIII";
            const string ROMAN_1684 = "MDCLXXXIV";
            const string ROMAN_1685 = "MDCLXXXV";
            const string ROMAN_1686 = "MDCLXXXVI";
            const string ROMAN_1687 = "MDCLXXXVII";
            const string ROMAN_1688 = "MDCLXXXVIII";
            const string ROMAN_1689 = "MDCLXXXIX";
            const string ROMAN_1690 = "MDCXC";

            const string ROMAN_1691 = "MDCXCI";
            const string ROMAN_1692 = "MDCXCII";
            const string ROMAN_1693 = "MDCXCIII";
            const string ROMAN_1694 = "MDCXCIV";
            const string ROMAN_1695 = "MDCXCV";
            const string ROMAN_1696 = "MDCXCVI";
            const string ROMAN_1697 = "MDCXCVII";
            const string ROMAN_1698 = "MDCXCVIII";
            const string ROMAN_1699 = "MDCXCIX";
            const string ROMAN_1700 = "MDCC";

            const string ROMAN_1701 = "MDCCI";
            const string ROMAN_1702 = "MDCCII";
            const string ROMAN_1703 = "MDCCIII";
            const string ROMAN_1704 = "MDCCIV";
            const string ROMAN_1705 = "MDCCV";
            const string ROMAN_1706 = "MDCCVI";
            const string ROMAN_1707 = "MDCCVII";
            const string ROMAN_1708 = "MDCCVIII";
            const string ROMAN_1709 = "MDCCIX";
            const string ROMAN_1710 = "MDCCX";

            const string ROMAN_1711 = "MDCCXI";
            const string ROMAN_1712 = "MDCCXII";
            const string ROMAN_1713 = "MDCCXIII";
            const string ROMAN_1714 = "MDCCXIV";
            const string ROMAN_1715 = "MDCCXV";
            const string ROMAN_1716 = "MDCCXVI";
            const string ROMAN_1717 = "MDCCXVII";
            const string ROMAN_1718 = "MDCCXVIII";
            const string ROMAN_1719 = "MDCCXIX";
            const string ROMAN_1720 = "MDCCXX";

            const string ROMAN_1721 = "MDCCXXI";
            const string ROMAN_1722 = "MDCCXXII";
            const string ROMAN_1723 = "MDCCXXIII";
            const string ROMAN_1724 = "MDCCXXIV";
            const string ROMAN_1725 = "MDCCXXV";
            const string ROMAN_1726 = "MDCCXXVI";
            const string ROMAN_1727 = "MDCCXXVII";
            const string ROMAN_1728 = "MDCCXXVIII";
            const string ROMAN_1729 = "MDCCXXIX";
            const string ROMAN_1730 = "MDCCXXX";

            const string ROMAN_1731 = "MDCCXXXI";
            const string ROMAN_1732 = "MDCCXII";
            const string ROMAN_1733 = "MDCCXXXIII";
            const string ROMAN_1734 = "MDCCXXXIV";
            const string ROMAN_1735 = "MDCCXXXV";
            const string ROMAN_1736 = "MDCCXXXVI";
            const string ROMAN_1737 = "MDCCXXXVII";
            const string ROMAN_1738 = "MDCCXXXVIII";
            const string ROMAN_1739 = "MDCCXXXIX";
            const string ROMAN_1740 = "MDCCXL";

            const string ROMAN_1741 = "MDCCXLI";
            const string ROMAN_1742 = "MDCCXLII";
            const string ROMAN_1743 = "MDCCXLIII";
            const string ROMAN_1744 = "MDCCXLIV";
            const string ROMAN_1745 = "MDCCXLV";
            const string ROMAN_1746 = "MDCCXLVI";
            const string ROMAN_1747 = "MDCCXLVII";
            const string ROMAN_1748 = "MDCCXLVIII";
            const string ROMAN_1749 = "MDCCXLIX";
            const string ROMAN_1750 = "MDCCL";

            const string ROMAN_1751 = "MDCCLI";
            const string ROMAN_1752 = "MDCCLII";
            const string ROMAN_1753 = "MDCCLIII";
            const string ROMAN_1754 = "MDCCLIV";
            const string ROMAN_1755 = "MDCCLV";
            const string ROMAN_1756 = "MDCCLVI";
            const string ROMAN_1757 = "MDCCLVII";
            const string ROMAN_1758 = "MDCCLVIII";
            const string ROMAN_1759 = "MDCCLIX";
            const string ROMAN_1760 = "MDCCLX";

            const string ROMAN_1761 = "MDCCLXI";
            const string ROMAN_1762 = "MDCCLXII";
            const string ROMAN_1763 = "MDCCLXIII";
            const string ROMAN_1764 = "MDCCLXIV";
            const string ROMAN_1765 = "MDCCLXV";
            const string ROMAN_1766 = "MDCCLXVI";
            const string ROMAN_1767 = "MDCCLXVII";
            const string ROMAN_1768 = "MDCCLXVIII";
            const string ROMAN_1769 = "MDCCLXIX";
            const string ROMAN_1770 = "MDCCLXX";


            const string ROMAN_1771 = "MDCCLXXI";
            const string ROMAN_1772 = "MDCCLXXII";
            const string ROMAN_1773 = "MDCCLXXIII";
            const string ROMAN_1774 = "MDCCLXXIV";
            const string ROMAN_1775 = "MDCCLXXV";
            const string ROMAN_1776 = "MDCCLXXVI";
            const string ROMAN_1777 = "MDCCLXXVII";
            const string ROMAN_1778 = "MDCCLXXVIII";
            const string ROMAN_1779 = "MDCCLXXIX";
            const string ROMAN_1780 = "MDCCLXXX";

            const string ROMAN_1781 = "MDCCLXXXI";
            const string ROMAN_1782 = "MDCCLXXXII";
            const string ROMAN_1783 = "MDCCLXXXIII";
            const string ROMAN_1784 = "MDCCLXXXIV";
            const string ROMAN_1785 = "MDCCLXXXV";
            const string ROMAN_1786 = "MDCCLXXXVI";
            const string ROMAN_1787 = "MDCCLXXXVII";
            const string ROMAN_1788 = "MDCCLXXXVIII";
            const string ROMAN_1789 = "MDCCLXXXIX";
            const string ROMAN_1790 = "MDCCXC";

            const string ROMAN_1791 = "MDCCXCI";
            const string ROMAN_1792 = "MDCCXCII";
            const string ROMAN_1793 = "MDCCXCIII";
            const string ROMAN_1794 = "MDCCXCIV";
            const string ROMAN_1795 = "MDCCXCV";
            const string ROMAN_1796 = "MDCCXCVI";
            const string ROMAN_1797 = "MDCCXCVII";
            const string ROMAN_1798 = "MDCCXCVIII";
            const string ROMAN_1799 = "MDCCXCIX";
            const string ROMAN_1800 = "MDCCC";

            const string ROMAN_1801 = "MDCCCI";
            const string ROMAN_1802 = "MDCCCII";
            const string ROMAN_1803 = "MDCCCIII";
            const string ROMAN_1804 = "MDCCCIV";
            const string ROMAN_1805 = "MDCCCV";
            const string ROMAN_1806 = "MDCCCVI";
            const string ROMAN_1807 = "MDCCCVII";
            const string ROMAN_1808 = "MDCCCVIII";
            const string ROMAN_1809 = "MDCCCIX";
            const string ROMAN_1810 = "MDCCCX";

            const string ROMAN_1811 = "MDCCCXI";
            const string ROMAN_1812 = "MDCCCXII";
            const string ROMAN_1813 = "MDCCCXIII";
            const string ROMAN_1814 = "MDCCCXIV";
            const string ROMAN_1815 = "MDCCCXV";
            const string ROMAN_1816 = "MDCCCXVI";
            const string ROMAN_1817 = "MDCCCXVII";
            const string ROMAN_1818 = "MDCCCXVIII";
            const string ROMAN_1819 = "MDCCCXIX";
            const string ROMAN_1820 = "MDCCCXX";

            const string ROMAN_1821 = "MDCCCXXI";
            const string ROMAN_1822 = "MDCCCXXII";
            const string ROMAN_1823 = "MDCCCXXIII";
            const string ROMAN_1824 = "MDCCCXXIV";
            const string ROMAN_1825 = "MDCCCXXV";
            const string ROMAN_1826 = "MDCCCXXVI";
            const string ROMAN_1827 = "MDCCCXXVII";
            const string ROMAN_1828 = "MDCCCXXVIII";
            const string ROMAN_1829 = "MDCCCXXIX";
            const string ROMAN_1830 = "MDCCCXXX";

            const string ROMAN_1831 = "MDCCCXXXI";
            const string ROMAN_1832 = "MDCCCXII";
            const string ROMAN_1833 = "MDCCCXXXIII";
            const string ROMAN_1834 = "MDCCCXXXIV";
            const string ROMAN_1835 = "MDCCCXXXV";
            const string ROMAN_1836 = "MDCCCXXXVI";
            const string ROMAN_1837 = "MDCCCXXXVII";
            const string ROMAN_1838 = "MDCCCXXXVIII";
            const string ROMAN_1839 = "MDCCCXXXIX";
            const string ROMAN_1840 = "MDCCCXL";

            const string ROMAN_1841 = "MDCCCXLI";
            const string ROMAN_1842 = "MDCCCXLII";
            const string ROMAN_1843 = "MDCCCXLIII";
            const string ROMAN_1844 = "MDCCCXLIV";
            const string ROMAN_1845 = "MDCCCXLV";
            const string ROMAN_1846 = "MDCCCXLVI";
            const string ROMAN_1847 = "MDCCCXLVII";
            const string ROMAN_1848 = "MDCCCXLVIII";
            const string ROMAN_1849 = "MDCCCXLIX";
            const string ROMAN_1850 = "MDCCCL";

            const string ROMAN_1851 = "MDCCCLI";
            const string ROMAN_1852 = "MDCCCLII";
            const string ROMAN_1853 = "MDCCCLIII";
            const string ROMAN_1854 = "MDCCCLIV";
            const string ROMAN_1855 = "MDCCCLV";
            const string ROMAN_1856 = "MDCCCLVI";
            const string ROMAN_1857 = "MDCCCLVII";
            const string ROMAN_1858 = "MDCCCLVIII";
            const string ROMAN_1859 = "MDCCCLIX";
            const string ROMAN_1860 = "MDCCCLX";

            const string ROMAN_1861 = "MDCCCLXI";
            const string ROMAN_1862 = "MVLXII";
            const string ROMAN_1863 = "MDCCCLXIII";
            const string ROMAN_1864 = "MDCCCLXIV";
            const string ROMAN_1865 = "MDCCCLXV";
            const string ROMAN_1866 = "MVLXVI";
            const string ROMAN_1867 = "MDCCCLXVII";
            const string ROMAN_1868 = "MDCCCLXVIII";
            const string ROMAN_1869 = "MDCCCLXIX";
            const string ROMAN_1870 = "MDCCCLXX";

            const string ROMAN_1871 = "MDCCCLXXI";
            const string ROMAN_1872 = "MDCCCLXXII";
            const string ROMAN_1873 = "MDCCCLXXIII";
            const string ROMAN_1874 = "MDCCCLXXIV";
            const string ROMAN_1875 = "MDCCCLXXV";
            const string ROMAN_1876 = "MDCCCLXXVI";
            const string ROMAN_1877 = "MDCCCLXXVII";
            const string ROMAN_1878 = "MDCCCLXXVIII";
            const string ROMAN_1879 = "MDCCCLXXIX";
            const string ROMAN_1880 = "MDCCCLXXX";

            const string ROMAN_1881 = "MDCCCLXXXI";
            const string ROMAN_1882 = "MDCCCLXXXII";
            const string ROMAN_1883 = "MDCCCLXXXIII";
            const string ROMAN_1884 = "MDCCCLXXXIV";
            const string ROMAN_1885 = "MDCCCLXXXV";
            const string ROMAN_1886 = "MDCCCLXXXVI";
            const string ROMAN_1887 = "MDCCCLXXXVII";
            const string ROMAN_1888 = "MDCCCLXXXVIII";
            const string ROMAN_1889 = "MDCCCLXXXIX";
            const string ROMAN_1890 = "MDCCCXC";

            const string ROMAN_1891 = "MDCCCXCI";
            const string ROMAN_1892 = "MDCCCXCII";
            const string ROMAN_1893 = "MDCCCXCIII";
            const string ROMAN_1894 = "MDCCCXCIV";
            const string ROMAN_1895 = "MDCCCXCV";
            const string ROMAN_1896 = "MDCCCXCVI";
            const string ROMAN_1897 = "MDCCCXCVII";
            const string ROMAN_1898 = "MDCCCXCVIII";
            const string ROMAN_1899 = "MDCCCXCIX";
            const string ROMAN_1900 = "MCM";

            const string ROMAN_1901 = "MCMI";
            const string ROMAN_1902 = "MCMII";
            const string ROMAN_1903 = "MCMIII";
            const string ROMAN_1904 = "MCMIV";
            const string ROMAN_1905 = "MCMV";
            const string ROMAN_1906 = "MCMVI";
            const string ROMAN_1907 = "MCMVII";
            const string ROMAN_1908 = "MCMVIII";
            const string ROMAN_1909 = "MCMIX";
            const string ROMAN_1910 = "MCMX";

            const string ROMAN_1911 = "MCMXI";
            const string ROMAN_1912 = "MCMXII";
            const string ROMAN_1913 = "MCMXIII";
            const string ROMAN_1914 = "MCMXIV";
            const string ROMAN_1915 = "MCMXV";
            const string ROMAN_1916 = "MCMXVI";
            const string ROMAN_1917 = "MCMXVII";
            const string ROMAN_1918 = "MCMXVIII";
            const string ROMAN_1919 = "MCMXIX";
            const string ROMAN_1920 = "MCMXX";

            const string ROMAN_1921 = "MCMXXI";
            const string ROMAN_1922 = "MCMXXII";
            const string ROMAN_1923 = "MCMXXIII";
            const string ROMAN_1924 = "MCMXXIV";
            const string ROMAN_1925 = "MCMXXV";
            const string ROMAN_1926 = "MCMXXVI";
            const string ROMAN_1927 = "MCMXXVII";
            const string ROMAN_1928 = "MCMXXVIII";
            const string ROMAN_1929 = "MCMXXIX";
            const string ROMAN_1930 = "MCMXXX";

            const string ROMAN_1931 = "MCMXXXI";
            const string ROMAN_1932 = "MCMXII";
            const string ROMAN_1933 = "MCMXXXIII";
            const string ROMAN_1934 = "MCMXXXIV";
            const string ROMAN_1935 = "MCMXXXV";
            const string ROMAN_1936 = "MCMXXXVI";
            const string ROMAN_1937 = "MCMXXXVII";
            const string ROMAN_1938 = "MCMXXXVIII";
            const string ROMAN_1939 = "MCMXXXIX";
            const string ROMAN_1940 = "MCMXL";

            const string ROMAN_1941 = "MCMXLI";
            const string ROMAN_1942 = "MCMXLII";
            const string ROMAN_1943 = "MCMXLIII";
            const string ROMAN_1944 = "MCMXLIV";
            const string ROMAN_1945 = "MCMXLV";
            const string ROMAN_1946 = "MCMXLVI";
            const string ROMAN_1947 = "MCMXLVII";
            const string ROMAN_1948 = "MCMXLVIII";
            const string ROMAN_1949 = "MCMXLIX";
            const string ROMAN_1950 = "MCML";

            const string ROMAN_1951 = "MCMLI";
            const string ROMAN_1952 = "MCMLII";
            const string ROMAN_1953 = "MCMLIII";
            const string ROMAN_1954 = "MCMLIV";
            const string ROMAN_1955 = "MCMLV";
            const string ROMAN_1956 = "MCMLVI";
            const string ROMAN_1957 = "MCMLVII";
            const string ROMAN_1958 = "MCMLVIII";
            const string ROMAN_1959 = "MCMLIX";
            const string ROMAN_1960 = "MCMLX";

            const string ROMAN_1961 = "MCMLXI";
            const string ROMAN_1962 = "MCMLXII";
            const string ROMAN_1963 = "MCMLXIII";
            const string ROMAN_1964 = "MCMLXIV";
            const string ROMAN_1965 = "MCMLXV";
            const string ROMAN_1966 = "MCMLXVI";
            const string ROMAN_1967 = "MCMLXVIII";
            const string ROMAN_1968 = "MCMLXVIII";
            const string ROMAN_1969 = "MCMLXIX";
            const string ROMAN_1970 = "MCMLXX";

            const string ROMAN_1971 = "MCMLXXI";
            const string ROMAN_1972 = "MCMLXXII";
            const string ROMAN_1973 = "MCMLXXIII";
            const string ROMAN_1974 = "MCMLXXIV";
            const string ROMAN_1975 = "MCMLXXV";
            const string ROMAN_1976 = "MCMLXXVI";
            const string ROMAN_1977 = "MCMLXXVII";
            const string ROMAN_1978 = "MCMLXXVIII";
            const string ROMAN_1979 = "MCMLXXIX";
            const string ROMAN_1980 = "MCMLXXX";

            const string ROMAN_1981 = "MCMLXXXI";
            const string ROMAN_1982 = "MCMLXXXII";
            const string ROMAN_1983 = "MCMLXXXIII";
            const string ROMAN_1984 = "MCMLXXXIV";
            const string ROMAN_1985 = "MCMLXXXV";
            const string ROMAN_1986 = "MCMLXXXVI";
            const string ROMAN_1987 = "MCMLXXXVII";
            const string ROMAN_1988 = "MCMLXXXVIII";
            const string ROMAN_1989 = "MCMLXXXIX";
            const string ROMAN_1990 = "MCMXC";

            const string ROMAN_1991 = "MCMXCI";
            const string ROMAN_1992 = "MCMXCII";
            const string ROMAN_1993 = "MCMXCIII";
            const string ROMAN_1994 = "MCMXCIV";
            const string ROMAN_1995 = "MCMXCV";
            const string ROMAN_1996 = "MCMXCVI";
            const string ROMAN_1997 = "MCMXCVII";
            const string ROMAN_1998 = "MCMXCVIII";
            const string ROMAN_1999 = "MCMXCIX";
            const string ROMAN_2000 = "MM";

            const string ROMAN_2001 = "MMI";
            const string ROMAN_2002 = "MMII";
            const string ROMAN_2003 = "MMIII";
            const string ROMAN_2004 = "MMCIV";
            const string ROMAN_2005 = "MMV";
            const string ROMAN_2006 = "MMVI";
            const string ROMAN_2007 = "MMVII";
            const string ROMAN_2008 = "MMVIII";
            const string ROMAN_2009 = "MMIX";
            const string ROMAN_2010 = "MMX";

            const string ROMAN_2011 = "MMXI";
            const string ROMAN_2012 = "MMXII";
            const string ROMAN_2013 = "MMXIII";
            const string ROMAN_2014 = "MMXIV";
            const string ROMAN_2015 = "MMXV";
            const string ROMAN_2016 = "MMXVI";
            const string ROMAN_2017 = "MMXVII";
            const string ROMAN_2018 = "MMXVIII";
            const string ROMAN_2019 = "MMXIX";
            const string ROMAN_2020 = "MMXX";

            const string ROMAN_2021 = "MMXXI";
            const string ROMAN_2022 = "MXXII";
            const string ROMAN_2023 = "MMXXIII";
            const string ROMAN_2024 = "MMXXIV";
            const string ROMAN_2025 = "MMXXV";
            const string ROMAN_2026 = "MMXXVI";
            const string ROMAN_2027 = "MMXXVII";
            const string ROMAN_2028 = "MMXXVIII";
            const string ROMAN_2029 = "MMXXIX";
            const string ROMAN_2030 = "MMXXX";

            const string ROMAN_2031 = "MMXXXI, skriv kun mulige byggeår ";
            const string ROMAN_2032 = "MMXXXII";
            const string ROMAN_2033 = "MMXXXIII";
            const string ROMAN_2034 = "MMXXXIV";
            const string ROMAN_2035 = "MMXXXV";
            const string ROMAN_2036 = "MMXXXVI";
            const string ROMAN_2037 = "MMXXXVII";
            const string ROMAN_2038 = "MMXXXVIII";
            const string ROMAN_2039 = "MMXXXIX";
            const string ROMAN_2040 = "MMXL The real Max";




            int number = 0;
            if (int.TryParse(textBox1.Text, out number))
            {
                if (number >= 1 && number <= 2040)
                {
                    switch (number)
                    {
                        case 1:
                            label1.Text = ROMAN_1;
                            break;
                        case 2:
                            label1.Text = ROMAN_2;
                            break;
                        case 3:
                            label1.Text = ROMAN_3;
                            break;
                        case 4:
                            label1.Text = ROMAN_4;
                            break;
                        case 5:
                            label1.Text = ROMAN_5;
                            break;
                        case 6:
                            label1.Text = ROMAN_6;
                            break;
                        case 7:
                            label1.Text = ROMAN_7;
                            break;
                        case 8:
                            label1.Text = ROMAN_8;
                            break;
                        case 9:
                            label1.Text = ROMAN_9;
                            break;
                        case 10:
                            label1.Text = ROMAN_10;
                            break;
         //               default:
         //                   label1.Text = "Kun årstallene 1 - 2030";
         //                  break;
                                                   case 11:
                                                        label1.Text = ROMAN_11;
                                                        break;
                                                        case 12:
                                                        label1.Text = ROMAN_12;
                                                        break;
                                                    case 13:
                                                        label1.Text = ROMAN_13;
                                                        break;
                                                    case 14:
                                                        label1.Text = ROMAN_14;
                                                        break;
                                                    case 15:
                                                        label1.Text = ROMAN_15;
                                                        break;
                                                    case 16:
                                                        label1.Text = ROMAN_16;
                                                        break;
                                                    case 17:
                                                        label1.Text = ROMAN_17;
                                                        break;
                                                    case 18:
                                                        label1.Text = ROMAN_18;
                                                        break;
                                                    case 19:
                                                        label1.Text = ROMAN_19;
                                                        break;
                                                    case 20:
                                                        label1.Text = ROMAN_20;
                                                        break;
                        case 21:
                            label1.Text = ROMAN_21;
                            break;
                        case 22:
                            label1.Text = ROMAN_22;
                            break;
                        case 23:
                            label1.Text = ROMAN_23;
                            break;
                        case 24:
                            label1.Text = ROMAN_24;
                            break;
                        case 25:
                            label1.Text = ROMAN_25;
                            break;
                        case 26:
                            label1.Text = ROMAN_26;
                            break;
                        case 27:
                            label1.Text = ROMAN_27;
                            break;
                        case 28:
                            label1.Text = ROMAN_28;
                            break;
                        case 29:
                            label1.Text = ROMAN_29;
                            break;
                        case 30:
                            label1.Text = ROMAN_30;
                            break;
                        
                        case 31:
                            label1.Text = ROMAN_31;
                            break;
                        case 32:
                            label1.Text = ROMAN_32;
                            break;
                        case 33:
                            label1.Text = ROMAN_33;
                            break;
                        case 34:
                            label1.Text = ROMAN_34;
                            break;
                        case 35:
                            label1.Text = ROMAN_35;
                            break;
                        case 36:
                            label1.Text = ROMAN_36;
                            break;
                        case 37:
                            label1.Text = ROMAN_37;
                            break;
                        case 38:
                            label1.Text = ROMAN_38;
                            break;
                        case 39:
                            label1.Text = ROMAN_39;
                            break;
                        case 40:
                            label1.Text = ROMAN_40;
                            break;

                        case 41:
                            label1.Text = ROMAN_41;
                            break;
                        case 42:
                            label1.Text = ROMAN_42;
                            break;
                        case 43:
                            label1.Text = ROMAN_43;
                            break;
                        case 44:
                            label1.Text = ROMAN_44;
                            break;
                        case 45:
                            label1.Text = ROMAN_45;
                            break;
                        case 46:
                            label1.Text = ROMAN_46;
                            break;
                        case 47:
                            label1.Text = ROMAN_47;
                            break;
                        case 48:
                            label1.Text = ROMAN_48;
                            break;
                        case 49:
                            label1.Text = ROMAN_49;
                            break;
                        case 50:
                            label1.Text = ROMAN_50;
                            break;
                       
                        case 51:
                            label1.Text = ROMAN_51;
                            break;
                        case 52:
                            label1.Text = ROMAN_52;
                            break;
                        case 53:
                            label1.Text = ROMAN_53;
                            break;
                        case 54:
                            label1.Text = ROMAN_54;
                            break;
                        case 55:
                            label1.Text = ROMAN_55;
                            break;
                        case 56:
                            label1.Text = ROMAN_56;
                            break;
                        case 57:
                            label1.Text = ROMAN_57;
                            break;
                        case 58:
                            label1.Text = ROMAN_58;
                            break;
                        case 59:
                            label1.Text = ROMAN_59;
                            break;
                        case 60:
                            label1.Text = ROMAN_60;
                            break;
                        case 61:
                            label1.Text = ROMAN_61;
                            break;
                        case 62:
                            label1.Text = ROMAN_62;
                            break;
                        case 63:
                            label1.Text = ROMAN_63;
                            break;
                        case 64:
                            label1.Text = ROMAN_64;
                            break;
                        case 65:
                            label1.Text = ROMAN_65;
                            break;
                        case 66:
                            label1.Text = ROMAN_66;
                            break;
                        case 67:
                            label1.Text = ROMAN_67;
                            break;
                        case 68:
                            label1.Text = ROMAN_68;
                            break;
                        case 69:
                            label1.Text = ROMAN_69;
                            break;
                        case 70:
                            label1.Text = ROMAN_70;
                            break;

                        case 71:
                            label1.Text = ROMAN_71;
                            break;
                        case 72:
                            label1.Text = ROMAN_72;
                            break;
                        case 73:
                            label1.Text = ROMAN_73;
                            break;
                        case 74:
                            label1.Text = ROMAN_74;
                            break;
                        case 75:
                            label1.Text = ROMAN_75;
                            break;
                        case 76:
                            label1.Text = ROMAN_76;
                            break;
                        case 77:
                            label1.Text = ROMAN_77;
                            break;
                        case 78:
                            label1.Text = ROMAN_78;
                            break;
                        case 79:
                            label1.Text = ROMAN_79;
                            break;
                        case 80:
                            label1.Text = ROMAN_80;
                            break;
                       
                        case 81:
                            label1.Text = ROMAN_81;
                            break;
                        case 82:
                            label1.Text = ROMAN_82;
                            break;
                        case 83:
                            label1.Text = ROMAN_83;
                            break;
                        case 84:
                            label1.Text = ROMAN_84;
                            break;
                        case 85:
                            label1.Text = ROMAN_85;
                            break;
                        case 86:
                            label1.Text = ROMAN_86;
                            break;
                        case 87:
                            label1.Text = ROMAN_87;
                            break;
                        case 88:
                            label1.Text = ROMAN_88;
                            break;
                        case 89:
                            label1.Text = ROMAN_89;
                            break;
                        case 90:
                            label1.Text = ROMAN_90;
                            break;

                        case 91:
                            label1.Text = ROMAN_91;
                            break;
                        case 92:
                            label1.Text = ROMAN_92;
                            break;
                        case 93:
                            label1.Text = ROMAN_93;
                            break;
                        case 94:
                            label1.Text = ROMAN_94;
                            break;
                        case 95:
                            label1.Text = ROMAN_95;
                            break;
                        case 96:
                            label1.Text = ROMAN_96;
                            break;
                        case 97:
                            label1.Text = ROMAN_97;
                            break;
                        case 98:
                            label1.Text = ROMAN_98;
                            break;
                        case 99:
                            label1.Text = ROMAN_99;
                            break;
                        case 100:
                            label1.Text = ROMAN_100;
                            break;
                        case 101:
                            label1.Text = ROMAN_101;
                            break;
                        case 102:
                            label1.Text = ROMAN_102;
                            break;
                        case 103:
                            label1.Text = ROMAN_103;
                            break;
                        case 104:
                            label1.Text = ROMAN_104;
                            break;
                        case 105:
                            label1.Text = ROMAN_105;
                            break;
                        case 106:
                            label1.Text = ROMAN_106;
                            break;
                        case 107:
                            label1.Text = ROMAN_107;
                            break;
                        case 108:
                            label1.Text = ROMAN_108;
                            break;
                        case 109:
                            label1.Text = ROMAN_109;
                            break;
                        case 110:
                            label1.Text = ROMAN_110;
                            break;
                        //               default:
                        //                   label1.Text = "Kun årstallene 1 - 2030";
                        //                  break;
                        case 111:
                            label1.Text = ROMAN_111;
                            break;
                        case 112:
                            label1.Text = ROMAN_112;
                            break;
                        case 113:
                            label1.Text = ROMAN_113;
                            break;
                        case 114:
                            label1.Text = ROMAN_114;
                            break;
                        case 115:
                            label1.Text = ROMAN_115;
                            break;
                        case 116:
                            label1.Text = ROMAN_116;
                            break;
                        case 117:
                            label1.Text = ROMAN_117;
                            break;
                        case 118:
                            label1.Text = ROMAN_118;
                            break;
                        case 119:
                            label1.Text = ROMAN_119;
                            break;
                        case 120:
                            label1.Text = ROMAN_120;
                            break;
                        case 121:
                            label1.Text = ROMAN_121;
                            break;
                        case 122:
                            label1.Text = ROMAN_122;
                            break;
                        case 123:
                            label1.Text = ROMAN_123;
                            break;
                        case 124:
                            label1.Text = ROMAN_124;
                            break;
                        case 125:
                            label1.Text = ROMAN_125;
                            break;
                        case 126:
                            label1.Text = ROMAN_126;
                            break;
                        case 127:
                            label1.Text = ROMAN_127;
                            break;
                        case 128:
                            label1.Text = ROMAN_128;
                            break;
                        case 129:
                            label1.Text = ROMAN_129;
                            break;
                        case 130:
                            label1.Text = ROMAN_130;
                            break;

                        case 131:
                            label1.Text = ROMAN_131;
                            break;
                        case 132:
                            label1.Text = ROMAN_132;
                            break;
                        case 133:
                            label1.Text = ROMAN_133;
                            break;
                        case 134:
                            label1.Text = ROMAN_134;
                            break;
                        case 135:
                            label1.Text = ROMAN_135;
                            break;
                        case 136:
                            label1.Text = ROMAN_136;
                            break;
                        case 137:
                            label1.Text = ROMAN_137;
                            break;
                        case 138:
                            label1.Text = ROMAN_138;
                            break;
                        case 139:
                            label1.Text = ROMAN_139;
                            break;
                        case 140:
                            label1.Text = ROMAN_140;
                            break;

                        case 141:
                            label1.Text = ROMAN_141;
                            break;
                        case 142:
                            label1.Text = ROMAN_142;
                            break;
                        case 143:
                            label1.Text = ROMAN_143;
                            break;
                        case 144:
                            label1.Text = ROMAN_144;
                            break;
                        case 145:
                            label1.Text = ROMAN_145;
                            break;
                        case 146:
                            label1.Text = ROMAN_146;
                            break;
                        case 147:
                            label1.Text = ROMAN_147;
                            break;
                        case 148:
                            label1.Text = ROMAN_148;
                            break;
                        case 149:
                            label1.Text = ROMAN_149;
                            break;
                        case 150:
                            label1.Text = ROMAN_150;
                            break;

                        case 151:
                            label1.Text = ROMAN_151;
                            break;
                        case 152:
                            label1.Text = ROMAN_152;
                            break;
                        case 153:
                            label1.Text = ROMAN_153;
                            break;
                        case 154:
                            label1.Text = ROMAN_154;
                            break;
                        case 155:
                            label1.Text = ROMAN_155;
                            break;
                        case 156:
                            label1.Text = ROMAN_156;
                            break;
                        case 157:
                            label1.Text = ROMAN_157;
                            break;
                        case 158:
                            label1.Text = ROMAN_158;
                            break;
                        case 159:
                            label1.Text = ROMAN_159;
                            break;
                        case 160:
                            label1.Text = ROMAN_160;
                            break;
                        case 161:
                            label1.Text = ROMAN_161;
                            break;
                        case 162:
                            label1.Text = ROMAN_162;
                            break;
                        case 163:
                            label1.Text = ROMAN_163;
                            break;
                        case 164:
                            label1.Text = ROMAN_164;
                            break;
                        case 165:
                            label1.Text = ROMAN_165;
                            break;
                        case 166:
                            label1.Text = ROMAN_166;
                            break;
                        case 167:
                            label1.Text = ROMAN_167;
                            break;
                        case 168:
                            label1.Text = ROMAN_168;
                            break;
                        case 169:
                            label1.Text = ROMAN_169;
                            break;
                        case 170:
                            label1.Text = ROMAN_170;
                            break;

                        case 171:
                            label1.Text = ROMAN_171;
                            break;
                        case 172:
                            label1.Text = ROMAN_172;
                            break;
                        case 173:
                            label1.Text = ROMAN_173;
                            break;
                        case 174:
                            label1.Text = ROMAN_174;
                            break;
                        case 175:
                            label1.Text = ROMAN_175;
                            break;
                        case 176:
                            label1.Text = ROMAN_176;
                            break;
                        case 177:
                            label1.Text = ROMAN_177;
                            break;
                        case 178:
                            label1.Text = ROMAN_178;
                            break;
                        case 179:
                            label1.Text = ROMAN_179;
                            break;
                        case 180:
                            label1.Text = ROMAN_180;
                            break;

                        case 181:
                            label1.Text = ROMAN_181;
                            break;
                        case 182:
                            label1.Text = ROMAN_182;
                            break;
                        case 183:
                            label1.Text = ROMAN_183;
                            break;
                        case 184:
                            label1.Text = ROMAN_184;
                            break;
                        case 185:
                            label1.Text = ROMAN_185;
                            break;
                        case 186:
                            label1.Text = ROMAN_186;
                            break;
                        case 187:
                            label1.Text = ROMAN_187;
                            break;
                        case 188:
                            label1.Text = ROMAN_188;
                            break;
                        case 189:
                            label1.Text = ROMAN_189;
                            break;
                        case 190:
                            label1.Text = ROMAN_190;
                            break;

                        case 191:
                            label1.Text = ROMAN_191;
                            break;
                        case 192:
                            label1.Text = ROMAN_192;
                            break;
                        case 193:
                            label1.Text = ROMAN_193;
                            break;
                        case 194:
                            label1.Text = ROMAN_194;
                            break;
                        case 195:
                            label1.Text = ROMAN_195;
                            break;
                        case 196:
                            label1.Text = ROMAN_196;
                            break;
                        case 197:
                            label1.Text = ROMAN_197;
                            break;
                        case 198:
                            label1.Text = ROMAN_198;
                            break;
                        case 199:
                            label1.Text = ROMAN_199;
                            break;
                        case 200:
                            label1.Text = ROMAN_200;
                            break;
                        case 201:
                            label1.Text = ROMAN_201;
                            break;
                        case 202:
                            label1.Text = ROMAN_202;
                            break;
                        case 203:
                            label1.Text = ROMAN_203;
                            break;
                        case 204:
                            label1.Text = ROMAN_204;
                            break;
                        case 205:
                            label1.Text = ROMAN_205;
                            break;
                        case 206:
                            label1.Text = ROMAN_206;
                            break;
                        case 207:
                            label1.Text = ROMAN_207;
                            break;
                        case 208:
                            label1.Text = ROMAN_208;
                            break;
                        case 209:
                            label1.Text = ROMAN_209;
                            break;
                        case 210:
                            label1.Text = ROMAN_210;
                            break;
                        //               default:
                        //                   label1.Text = "Kun årstallene 1 - 2030";
                        //                  break;
                        case 211:
                            label1.Text = ROMAN_211;
                            break;
                        case 212:
                            label1.Text = ROMAN_212;
                            break;
                        case 213:
                            label1.Text = ROMAN_213;
                            break;
                        case 214:
                            label1.Text = ROMAN_214;
                            break;
                        case 215:
                            label1.Text = ROMAN_215;
                            break;
                        case 216:
                            label1.Text = ROMAN_216;
                            break;
                        case 217:
                            label1.Text = ROMAN_217;
                            break;
                        case 218:
                            label1.Text = ROMAN_218;
                            break;
                        case 219:
                            label1.Text = ROMAN_219;
                            break;
                        case 220:
                            label1.Text = ROMAN_220;
                            break;
                        case 221:
                            label1.Text = ROMAN_221;
                            break;
                        case 222:
                            label1.Text = ROMAN_222;
                            break;
                        case 223:
                            label1.Text = ROMAN_223;
                            break;
                        case 224:
                            label1.Text = ROMAN_224;
                            break;
                        case 225:
                            label1.Text = ROMAN_225;
                            break;
                        case 226:
                            label1.Text = ROMAN_226;
                            break;
                        case 227:
                            label1.Text = ROMAN_227;
                            break;
                        case 228:
                            label1.Text = ROMAN_228;
                            break;
                        case 229:
                            label1.Text = ROMAN_229;
                            break;
                        case 230:
                            label1.Text = ROMAN_230;
                            break;

                        case 231:
                            label1.Text = ROMAN_231;
                            break;
                        case 232:
                            label1.Text = ROMAN_232;
                            break;
                        case 233:
                            label1.Text = ROMAN_233;
                            break;
                        case 234:
                            label1.Text = ROMAN_234;
                            break;
                        case 235:
                            label1.Text = ROMAN_235;
                            break;
                        case 236:
                            label1.Text = ROMAN_236;
                            break;
                        case 237:
                            label1.Text = ROMAN_237;
                            break;
                        case 238:
                            label1.Text = ROMAN_238;
                            break;
                        case 239:
                            label1.Text = ROMAN_239;
                            break;
                        case 240:
                            label1.Text = ROMAN_240;
                            break;

                        case 241:
                            label1.Text = ROMAN_241;
                            break;
                        case 242:
                            label1.Text = ROMAN_242;
                            break;
                        case 243:
                            label1.Text = ROMAN_243;
                            break;
                        case 244:
                            label1.Text = ROMAN_244;
                            break;
                        case 245:
                            label1.Text = ROMAN_245;
                            break;
                        case 246:
                            label1.Text = ROMAN_246;
                            break;
                        case 247:
                            label1.Text = ROMAN_247;
                            break;
                        case 248:
                            label1.Text = ROMAN_248;
                            break;
                        case 249:
                            label1.Text = ROMAN_249;
                            break;
                        case 250:
                            label1.Text = ROMAN_250;
                            break;

                        case 251:
                            label1.Text = ROMAN_251;
                            break;
                        case 252:
                            label1.Text = ROMAN_252;
                            break;
                        case 253:
                            label1.Text = ROMAN_253;
                            break;
                        case 254:
                            label1.Text = ROMAN_254;
                            break;
                        case 255:
                            label1.Text = ROMAN_255;
                            break;
                        case 256:
                            label1.Text = ROMAN_256;
                            break;
                        case 257:
                            label1.Text = ROMAN_257;
                            break;
                        case 258:
                            label1.Text = ROMAN_258;
                            break;
                        case 259:
                            label1.Text = ROMAN_259;
                            break;
                        case 260:
                            label1.Text = ROMAN_260;
                            break;
                        case 261:
                            label1.Text = ROMAN_261;
                            break;
                        case 262:
                            label1.Text = ROMAN_262;
                            break;
                        case 263:
                            label1.Text = ROMAN_263;
                            break;
                        case 264:
                            label1.Text = ROMAN_264;
                            break;
                        case 265:
                            label1.Text = ROMAN_265;
                            break;
                        case 266:
                            label1.Text = ROMAN_266;
                            break;
                        case 267:
                            label1.Text = ROMAN_267;
                            break;
                        case 268:
                            label1.Text = ROMAN_268;
                            break;
                        case 269:
                            label1.Text = ROMAN_269;
                            break;
                        case 270:
                            label1.Text = ROMAN_270;
                            break;

                        case 271:
                            label1.Text = ROMAN_271;
                            break;
                        case 272:
                            label1.Text = ROMAN_272;
                            break;
                        case 273:
                            label1.Text = ROMAN_273;
                            break;
                        case 274:
                            label1.Text = ROMAN_274;
                            break;
                        case 275:
                            label1.Text = ROMAN_275;
                            break;
                        case 276:
                            label1.Text = ROMAN_276;
                            break;
                        case 277:
                            label1.Text = ROMAN_277;
                            break;
                        case 278:
                            label1.Text = ROMAN_278;
                            break;
                        case 279:
                            label1.Text = ROMAN_279;
                            break;
                        case 280:
                            label1.Text = ROMAN_280;
                            break;

                        case 281:
                            label1.Text = ROMAN_281;
                            break;
                        case 282:
                            label1.Text = ROMAN_282;
                            break;
                        case 283:
                            label1.Text = ROMAN_283;
                            break;
                        case 284:
                            label1.Text = ROMAN_284;
                            break;
                        case 285:
                            label1.Text = ROMAN_285;
                            break;
                        case 286:
                            label1.Text = ROMAN_286;
                            break;
                        case 287:
                            label1.Text = ROMAN_287;
                            break;
                        case 288:
                            label1.Text = ROMAN_288;
                            break;
                        case 289:
                            label1.Text = ROMAN_289;
                            break;
                        case 290:
                            label1.Text = ROMAN_290;
                            break;

                        case 291:
                            label1.Text = ROMAN_291;
                            break;
                        case 292:
                            label1.Text = ROMAN_292;
                            break;
                        case 293:
                            label1.Text = ROMAN_293;
                            break;
                        case 294:
                            label1.Text = ROMAN_294;
                            break;
                        case 295:
                            label1.Text = ROMAN_295;
                            break;
                        case 296:
                            label1.Text = ROMAN_296;
                            break;
                        case 297:
                            label1.Text = ROMAN_297;
                            break;
                        case 298:
                            label1.Text = ROMAN_298;
                            break;
                        case 299:
                            label1.Text = ROMAN_299;
                            break;
                        case 300:
                            label1.Text = ROMAN_300;
                            break;
                        case 301:
                            label1.Text = ROMAN_301;
                            break;
                        case 302:
                            label1.Text = ROMAN_302;
                            break;
                        case 303:
                            label1.Text = ROMAN_303;
                            break;
                        case 304:
                            label1.Text = ROMAN_304;
                            break;
                        case 305:
                            label1.Text = ROMAN_305;
                            break;
                        case 306:
                            label1.Text = ROMAN_306;
                            break;
                        case 307:
                            label1.Text = ROMAN_307;
                            break;
                        case 308:
                            label1.Text = ROMAN_308;
                            break;
                        case 309:
                            label1.Text = ROMAN_309;
                            break;
                        case 310:
                            label1.Text = ROMAN_310;
                            break;
                        //               default:
                        //                   label1.Text = "Kun årstallene 1 - 2030";
                        //                  break;
                        case 311:
                            label1.Text = ROMAN_311;
                            break;
                        case 312:
                            label1.Text = ROMAN_312;
                            break;
                        case 313:
                            label1.Text = ROMAN_313;
                            break;
                        case 314:
                            label1.Text = ROMAN_314;
                            break;
                        case 315:
                            label1.Text = ROMAN_315;
                            break;
                        case 316:
                            label1.Text = ROMAN_316;
                            break;
                        case 317:
                            label1.Text = ROMAN_317;
                            break;
                        case 318:
                            label1.Text = ROMAN_318;
                            break;
                        case 319:
                            label1.Text = ROMAN_319;
                            break;
                        case 320:
                            label1.Text = ROMAN_320;
                            break;
                        case 321:
                            label1.Text = ROMAN_321;
                            break;
                        case 322:
                            label1.Text = ROMAN_322;
                            break;
                        case 323:
                            label1.Text = ROMAN_323;
                            break;
                        case 324:
                            label1.Text = ROMAN_324;
                            break;
                        case 325:
                            label1.Text = ROMAN_325;
                            break;
                        case 326:
                            label1.Text = ROMAN_326;
                            break;
                        case 327:
                            label1.Text = ROMAN_327;
                            break;
                        case 328:
                            label1.Text = ROMAN_328;
                            break;
                        case 329:
                            label1.Text = ROMAN_329;
                            break;
                        case 330:
                            label1.Text = ROMAN_330;
                            break;

                        case 331:
                            label1.Text = ROMAN_331;
                            break;
                        case 332:
                            label1.Text = ROMAN_332;
                            break;
                        case 333:
                            label1.Text = ROMAN_333;
                            break;
                        case 334:
                            label1.Text = ROMAN_334;
                            break;
                        case 335:
                            label1.Text = ROMAN_335;
                            break;
                        case 336:
                            label1.Text = ROMAN_336;
                            break;
                        case 337:
                            label1.Text = ROMAN_337;
                            break;
                        case 338:
                            label1.Text = ROMAN_338;
                            break;
                        case 339:
                            label1.Text = ROMAN_339;
                            break;
                        case 340:
                            label1.Text = ROMAN_340;
                            break;

                        case 341:
                            label1.Text = ROMAN_341;
                            break;
                        case 342:
                            label1.Text = ROMAN_342;
                            break;
                        case 343:
                            label1.Text = ROMAN_343;
                            break;
                        case 344:
                            label1.Text = ROMAN_344;
                            break;
                        case 345:
                            label1.Text = ROMAN_345;
                            break;
                        case 346:
                            label1.Text = ROMAN_346;
                            break;
                        case 347:
                            label1.Text = ROMAN_347;
                            break;
                        case 348:
                            label1.Text = ROMAN_348;
                            break;
                        case 349:
                            label1.Text = ROMAN_349;
                            break;
                        case 350:
                            label1.Text = ROMAN_350;
                            break;

                        case 351:
                            label1.Text = ROMAN_351;
                            break;
                        case 352:
                            label1.Text = ROMAN_352;
                            break;
                        case 353:
                            label1.Text = ROMAN_353;
                            break;
                        case 354:
                            label1.Text = ROMAN_354;
                            break;
                        case 355:
                            label1.Text = ROMAN_355;
                            break;
                        case 356:
                            label1.Text = ROMAN_356;
                            break;
                        case 357:
                            label1.Text = ROMAN_357;
                            break;
                        case 358:
                            label1.Text = ROMAN_358;
                            break;
                        case 359:
                            label1.Text = ROMAN_359;
                            break;
                        case 360:
                            label1.Text = ROMAN_360;
                            break;
                        case 361:
                            label1.Text = ROMAN_361;
                            break;
                        case 362:
                            label1.Text = ROMAN_362;
                            break;
                        case 363:
                            label1.Text = ROMAN_363;
                            break;
                        case 364:
                            label1.Text = ROMAN_364;
                            break;
                        case 365:
                            label1.Text = ROMAN_365;
                            break;
                        case 366:
                            label1.Text = ROMAN_366;
                            break;
                        case 367:
                            label1.Text = ROMAN_367;
                            break;
                        case 368:
                            label1.Text = ROMAN_368;
                            break;
                        case 369:
                            label1.Text = ROMAN_369;
                            break;
                        case 370:
                            label1.Text = ROMAN_370;
                            break;

                        case 371:
                            label1.Text = ROMAN_371;
                            break;
                        case 372:
                            label1.Text = ROMAN_372;
                            break;
                        case 373:
                            label1.Text = ROMAN_373;
                            break;
                        case 374:
                            label1.Text = ROMAN_374;
                            break;
                        case 375:
                            label1.Text = ROMAN_375;
                            break;
                        case 376:
                            label1.Text = ROMAN_376;
                            break;
                        case 377:
                            label1.Text = ROMAN_377;
                            break;
                        case 378:
                            label1.Text = ROMAN_378;
                            break;
                        case 379:
                            label1.Text = ROMAN_379;
                            break;
                        case 380:
                            label1.Text = ROMAN_380;
                            break;

                        case 381:
                            label1.Text = ROMAN_381;
                            break;
                        case 382:
                            label1.Text = ROMAN_382;
                            break;
                        case 383:
                            label1.Text = ROMAN_383;
                            break;
                        case 384:
                            label1.Text = ROMAN_384;
                            break;
                        case 385:
                            label1.Text = ROMAN_385;
                            break;
                        case 386:
                            label1.Text = ROMAN_386;
                            break;
                        case 387:
                            label1.Text = ROMAN_387;
                            break;
                        case 388:
                            label1.Text = ROMAN_388;
                            break;
                        case 389:
                            label1.Text = ROMAN_389;
                            break;
                        case 390:
                            label1.Text = ROMAN_390;
                            break;

                        case 391:
                            label1.Text = ROMAN_391;
                            break;
                        case 392:
                            label1.Text = ROMAN_392;
                            break;
                        case 393:
                            label1.Text = ROMAN_393;
                            break;
                        case 394:
                            label1.Text = ROMAN_394;
                            break;
                        case 395:
                            label1.Text = ROMAN_395;
                            break;
                        case 396:
                            label1.Text = ROMAN_396;
                            break;
                        case 397:
                            label1.Text = ROMAN_397;
                            break;
                        case 398:
                            label1.Text = ROMAN_398;
                            break;
                        case 399:
                            label1.Text = ROMAN_399;
                            break;
                        case 400:
                            label1.Text = ROMAN_400;
                            break;

                        case 401:
                            label1.Text = ROMAN_401;
                            break;
                        case 402:
                            label1.Text = ROMAN_402;
                            break;
                        case 403:
                            label1.Text = ROMAN_403;
                            break;
                        case 404:
                            label1.Text = ROMAN_404;
                            break;
                        case 405:
                            label1.Text = ROMAN_405;
                            break;
                        case 406:
                            label1.Text = ROMAN_406;
                            break;
                        case 407:
                            label1.Text = ROMAN_407;
                            break;
                        case 408:
                            label1.Text = ROMAN_408;
                            break;
                        case 409:
                            label1.Text = ROMAN_409;
                            break;
                        case 410:
                            label1.Text = ROMAN_410;
                            break;
                        //               default:
                        //                   label1.Text = "Kun årstallene 1 - 2030";
                        //                  break;
                        case 411:
                            label1.Text = ROMAN_411;
                            break;
                        case 412:
                            label1.Text = ROMAN_412;
                            break;
                        case 413:
                            label1.Text = ROMAN_413;
                            break;
                        case 414:
                            label1.Text = ROMAN_414;
                            break;
                        case 415:
                            label1.Text = ROMAN_415;
                            break;
                        case 416:
                            label1.Text = ROMAN_416;
                            break;
                        case 417:
                            label1.Text = ROMAN_417;
                            break;
                        case 418:
                            label1.Text = ROMAN_418;
                            break;
                        case 419:
                            label1.Text = ROMAN_419;
                            break;
                        case 420:
                            label1.Text = ROMAN_420;
                            break;
                        case 421:
                            label1.Text = ROMAN_421;
                            break;
                        case 422:
                            label1.Text = ROMAN_422;
                            break;
                        case 423:
                            label1.Text = ROMAN_423;
                            break;
                        case 424:
                            label1.Text = ROMAN_424;
                            break;
                        case 425:
                            label1.Text = ROMAN_425;
                            break;
                        case 426:
                            label1.Text = ROMAN_426;
                            break;
                        case 427:
                            label1.Text = ROMAN_427;
                            break;
                        case 428:
                            label1.Text = ROMAN_428;
                            break;
                        case 429:
                            label1.Text = ROMAN_429;
                            break;
                        case 430:
                            label1.Text = ROMAN_430;
                            break;

                        case 431:
                            label1.Text = ROMAN_431;
                            break;
                        case 432:
                            label1.Text = ROMAN_432;
                            break;
                        case 433:
                            label1.Text = ROMAN_433;
                            break;
                        case 434:
                            label1.Text = ROMAN_434;
                            break;
                        case 435:
                            label1.Text = ROMAN_435;
                            break;
                        case 436:
                            label1.Text = ROMAN_436;
                            break;
                        case 437:
                            label1.Text = ROMAN_437;
                            break;
                        case 438:
                            label1.Text = ROMAN_438;
                            break;
                        case 439:
                            label1.Text = ROMAN_439;
                            break;
                        case 440:
                            label1.Text = ROMAN_440;
                            break;

                        case 441:
                            label1.Text = ROMAN_441;
                            break;
                        case 442:
                            label1.Text = ROMAN_442;
                            break;
                        case 443:
                            label1.Text = ROMAN_443;
                            break;
                        case 444:
                            label1.Text = ROMAN_444;
                            break;
                        case 445:
                            label1.Text = ROMAN_445;
                            break;
                        case 446:
                            label1.Text = ROMAN_446;
                            break;
                        case 447:
                            label1.Text = ROMAN_447;
                            break;
                        case 448:
                            label1.Text = ROMAN_448;
                            break;
                        case 449:
                            label1.Text = ROMAN_449;
                            break;
                        case 450:
                            label1.Text = ROMAN_450;
                            break;

                        case 451:
                            label1.Text = ROMAN_451;
                            break;
                        case 452:
                            label1.Text = ROMAN_452;
                            break;
                        case 453:
                            label1.Text = ROMAN_453;
                            break;
                        case 454:
                            label1.Text = ROMAN_454;
                            break;
                        case 455:
                            label1.Text = ROMAN_455;
                            break;
                        case 456:
                            label1.Text = ROMAN_456;
                            break;
                        case 457:
                            label1.Text = ROMAN_457;
                            break;
                        case 458:
                            label1.Text = ROMAN_458;
                            break;
                        case 459:
                            label1.Text = ROMAN_459;
                            break;
                        case 460:
                            label1.Text = ROMAN_460;
                            break;
                        case 461:
                            label1.Text = ROMAN_461;
                            break;
                        case 462:
                            label1.Text = ROMAN_462;
                            break;
                        case 463:
                            label1.Text = ROMAN_463;
                            break;
                        case 464:
                            label1.Text = ROMAN_464;
                            break;
                        case 465:
                            label1.Text = ROMAN_465;
                            break;
                        case 466:
                            label1.Text = ROMAN_466;
                            break;
                        case 467:
                            label1.Text = ROMAN_467;
                            break;
                        case 468:
                            label1.Text = ROMAN_468;
                            break;
                        case 469:
                            label1.Text = ROMAN_469;
                            break;
                        case 470:
                            label1.Text = ROMAN_470;
                            break;

                        case 471:
                            label1.Text = ROMAN_471;
                            break;
                        case 472:
                            label1.Text = ROMAN_472;
                            break;
                        case 473:
                            label1.Text = ROMAN_473;
                            break;
                        case 474:
                            label1.Text = ROMAN_474;
                            break;
                        case 475:
                            label1.Text = ROMAN_475;
                            break;
                        case 476:
                            label1.Text = ROMAN_476;
                            break;
                        case 477:
                            label1.Text = ROMAN_477;
                            break;
                        case 478:
                            label1.Text = ROMAN_478;
                            break;
                        case 479:
                            label1.Text = ROMAN_479;
                            break;
                        case 480:
                            label1.Text = ROMAN_480;
                            break;

                        case 481:
                            label1.Text = ROMAN_481;
                            break;
                        case 482:
                            label1.Text = ROMAN_482;
                            break;
                        case 483:
                            label1.Text = ROMAN_483;
                            break;
                        case 484:
                            label1.Text = ROMAN_484;
                            break;
                        case 485:
                            label1.Text = ROMAN_485;
                            break;
                        case 486:
                            label1.Text = ROMAN_486;
                            break;
                        case 487:
                            label1.Text = ROMAN_487;
                            break;
                        case 488:
                            label1.Text = ROMAN_488;
                            break;
                        case 489:
                            label1.Text = ROMAN_489;
                            break;
                        case 490:
                            label1.Text = ROMAN_490;
                            break;

                        case 491:
                            label1.Text = ROMAN_491;
                            break;
                        case 492:
                            label1.Text = ROMAN_492;
                            break;
                        case 493:
                            label1.Text = ROMAN_493;
                            break;
                        case 494:
                            label1.Text = ROMAN_494;
                            break;
                        case 495:
                            label1.Text = ROMAN_495;
                            break;
                        case 496:
                            label1.Text = ROMAN_496;
                            break;
                        case 497:
                            label1.Text = ROMAN_497;
                            break;
                        case 498:
                            label1.Text = ROMAN_498;
                            break;
                        case 499:
                            label1.Text = ROMAN_499;
                            break;
                        case 500:
                            label1.Text = ROMAN_500;
                            break;
                        case 501:
                            label1.Text = ROMAN_501;
                            break;
                        case 502:
                            label1.Text = ROMAN_502;
                            break;
                        case 503:
                            label1.Text = ROMAN_503;
                            break;
                        case 504:
                            label1.Text = ROMAN_504;
                            break;
                        case 505:
                            label1.Text = ROMAN_505;
                            break;
                        case 506:
                            label1.Text = ROMAN_506;
                            break;
                        case 507:
                            label1.Text = ROMAN_507;
                            break;
                        case 508:
                            label1.Text = ROMAN_508;
                            break;
                        case 509:
                            label1.Text = ROMAN_509;
                            break;
                        case 510:
                            label1.Text = ROMAN_510;
                            break;
                        //               default:
                        //                   label1.Text = "Kun årstallene 1 - 2030";
                        //                  break;
                        case 511:
                            label1.Text = ROMAN_511;
                            break;
                        case 512:
                            label1.Text = ROMAN_512;
                            break;
                        case 513:
                            label1.Text = ROMAN_513;
                            break;
                        case 514:
                            label1.Text = ROMAN_514;
                            break;
                        case 515:
                            label1.Text = ROMAN_515;
                            break;
                        case 516:
                            label1.Text = ROMAN_516;
                            break;
                        case 517:
                            label1.Text = ROMAN_517;
                            break;
                        case 518:
                            label1.Text = ROMAN_518;
                            break;
                        case 519:
                            label1.Text = ROMAN_519;
                            break;
                        case 520:
                            label1.Text = ROMAN_520;
                            break;
                        case 521:
                            label1.Text = ROMAN_521;
                            break;
                        case 522:
                            label1.Text = ROMAN_522;
                            break;
                        case 523:
                            label1.Text = ROMAN_523;
                            break;
                        case 524:
                            label1.Text = ROMAN_524;
                            break;
                        case 525:
                            label1.Text = ROMAN_525;
                            break;
                        case 526:
                            label1.Text = ROMAN_526;
                            break;
                        case 527:
                            label1.Text = ROMAN_527;
                            break;
                        case 528:
                            label1.Text = ROMAN_528;
                            break;
                        case 529:
                            label1.Text = ROMAN_529;
                            break;
                        case 530:
                            label1.Text = ROMAN_530;
                            break;

                        case 531:
                            label1.Text = ROMAN_531;
                            break;
                        case 532:
                            label1.Text = ROMAN_532;
                            break;
                        case 533:
                            label1.Text = ROMAN_533;
                            break;
                        case 534:
                            label1.Text = ROMAN_534;
                            break;
                        case 535:
                            label1.Text = ROMAN_535;
                            break;
                        case 536:
                            label1.Text = ROMAN_536;
                            break;
                        case 537:
                            label1.Text = ROMAN_537;
                            break;
                        case 538:
                            label1.Text = ROMAN_538;
                            break;
                        case 539:
                            label1.Text = ROMAN_539;
                            break;
                        case 540:
                            label1.Text = ROMAN_540;
                            break;

                        case 541:
                            label1.Text = ROMAN_541;
                            break;
                        case 542:
                            label1.Text = ROMAN_542;
                            break;
                        case 543:
                            label1.Text = ROMAN_543;
                            break;
                        case 544:
                            label1.Text = ROMAN_544;
                            break;
                        case 545:
                            label1.Text = ROMAN_545;
                            break;
                        case 546:
                            label1.Text = ROMAN_546;
                            break;
                        case 547:
                            label1.Text = ROMAN_547;
                            break;
                        case 548:
                            label1.Text = ROMAN_548;
                            break;
                        case 549:
                            label1.Text = ROMAN_549;
                            break;
                        case 550:
                            label1.Text = ROMAN_550;
                            break;

                        case 551:
                            label1.Text = ROMAN_551;
                            break;
                        case 552:
                            label1.Text = ROMAN_552;
                            break;
                        case 553:
                            label1.Text = ROMAN_553;
                            break;
                        case 554:
                            label1.Text = ROMAN_554;
                            break;
                        case 555:
                            label1.Text = ROMAN_555;
                            break;
                        case 556:
                            label1.Text = ROMAN_556;
                            break;
                        case 557:
                            label1.Text = ROMAN_557;
                            break;
                        case 558:
                            label1.Text = ROMAN_558;
                            break;
                        case 559:
                            label1.Text = ROMAN_559;
                            break;
                        case 560:
                            label1.Text = ROMAN_560;
                            break;
                        case 561:
                            label1.Text = ROMAN_561;
                            break;
                        case 562:
                            label1.Text = ROMAN_562;
                            break;
                        case 563:
                            label1.Text = ROMAN_563;
                            break;
                        case 564:
                            label1.Text = ROMAN_564;
                            break;
                        case 565:
                            label1.Text = ROMAN_565;
                            break;
                        case 566:
                            label1.Text = ROMAN_566;
                            break;
                        case 567:
                            label1.Text = ROMAN_567;
                            break;
                        case 568:
                            label1.Text = ROMAN_568;
                            break;
                        case 569:
                            label1.Text = ROMAN_569;
                            break;
                        case 570:
                            label1.Text = ROMAN_570;
                            break;

                        case 571:
                            label1.Text = ROMAN_571;
                            break;
                        case 572:
                            label1.Text = ROMAN_572;
                            break;
                        case 573:
                            label1.Text = ROMAN_573;
                            break;
                        case 574:
                            label1.Text = ROMAN_574;
                            break;
                        case 575:
                            label1.Text = ROMAN_575;
                            break;
                        case 576:
                            label1.Text = ROMAN_576;
                            break;
                        case 577:
                            label1.Text = ROMAN_577;
                            break;
                        case 578:
                            label1.Text = ROMAN_578;
                            break;
                        case 579:
                            label1.Text = ROMAN_579;
                            break;
                        case 580:
                            label1.Text = ROMAN_580;
                            break;

                        case 581:
                            label1.Text = ROMAN_581;
                            break;
                        case 582:
                            label1.Text = ROMAN_582;
                            break;
                        case 583:
                            label1.Text = ROMAN_583;
                            break;
                        case 584:
                            label1.Text = ROMAN_584;
                            break;
                        case 585:
                            label1.Text = ROMAN_585;
                            break;
                        case 586:
                            label1.Text = ROMAN_586;
                            break;
                        case 587:
                            label1.Text = ROMAN_587;
                            break;
                        case 588:
                            label1.Text = ROMAN_588;
                            break;
                        case 589:
                            label1.Text = ROMAN_589;
                            break;
                        case 590:
                            label1.Text = ROMAN_590;
                            break;

                        case 591:
                            label1.Text = ROMAN_591;
                            break;
                        case 592:
                            label1.Text = ROMAN_592;
                            break;
                        case 593:
                            label1.Text = ROMAN_593;
                            break;
                        case 594:
                            label1.Text = ROMAN_594;
                            break;
                        case 595:
                            label1.Text = ROMAN_595;
                            break;
                        case 596:
                            label1.Text = ROMAN_596;
                            break;
                        case 597:
                            label1.Text = ROMAN_597;
                            break;
                        case 598:
                            label1.Text = ROMAN_598;
                            break;
                        case 599:
                            label1.Text = ROMAN_599;
                            break;
                        case 600:
                            label1.Text = ROMAN_600;
                            break;
                        case 601:
                            label1.Text = ROMAN_601;
                            break;
                        case 602:
                            label1.Text = ROMAN_602;
                            break;
                        case 603:
                            label1.Text = ROMAN_603;
                            break;
                        case 604:
                            label1.Text = ROMAN_604;
                            break;
                        case 605:
                            label1.Text = ROMAN_605;
                            break;
                        case 606:
                            label1.Text = ROMAN_606;
                            break;
                        case 607:
                            label1.Text = ROMAN_607;
                            break;
                        case 608:
                            label1.Text = ROMAN_608;
                            break;
                        case 609:
                            label1.Text = ROMAN_609;
                            break;
                        case 610:
                            label1.Text = ROMAN_610;
                            break;
                        //               default:
                        //                   label1.Text = "Kun årstallene 1 - 2030";
                        //                  break;
                        case 611:
                            label1.Text = ROMAN_611;
                            break;
                        case 612:
                            label1.Text = ROMAN_612;
                            break;
                        case 613:
                            label1.Text = ROMAN_613;
                            break;
                        case 614:
                            label1.Text = ROMAN_614;
                            break;
                        case 615:
                            label1.Text = ROMAN_615;
                            break;
                        case 616:
                            label1.Text = ROMAN_616;
                            break;
                        case 617:
                            label1.Text = ROMAN_617;
                            break;
                        case 618:
                            label1.Text = ROMAN_618;
                            break;
                        case 619:
                            label1.Text = ROMAN_619;
                            break;
                        case 620:
                            label1.Text = ROMAN_620;
                            break;
                        case 621:
                            label1.Text = ROMAN_621;
                            break;
                        case 622:
                            label1.Text = ROMAN_622;
                            break;
                        case 623:
                            label1.Text = ROMAN_623;
                            break;
                        case 624:
                            label1.Text = ROMAN_624;
                            break;
                        case 625:
                            label1.Text = ROMAN_625;
                            break;
                        case 626:
                            label1.Text = ROMAN_626;
                            break;
                        case 627:
                            label1.Text = ROMAN_627;
                            break;
                        case 628:
                            label1.Text = ROMAN_628;
                            break;
                        case 629:
                            label1.Text = ROMAN_629;
                            break;
                        case 630:
                            label1.Text = ROMAN_630;
                            break;

                        case 631:
                            label1.Text = ROMAN_631;
                            break;
                        case 632:
                            label1.Text = ROMAN_632;
                            break;
                        case 633:
                            label1.Text = ROMAN_633;
                            break;
                        case 634:
                            label1.Text = ROMAN_634;
                            break;
                        case 635:
                            label1.Text = ROMAN_635;
                            break;
                        case 636:
                            label1.Text = ROMAN_636;
                            break;
                        case 637:
                            label1.Text = ROMAN_637;
                            break;
                        case 638:
                            label1.Text = ROMAN_638;
                            break;
                        case 639:
                            label1.Text = ROMAN_639;
                            break;
                        case 640:
                            label1.Text = ROMAN_640;
                            break;

                        case 641:
                            label1.Text = ROMAN_641;
                            break;
                        case 642:
                            label1.Text = ROMAN_642;
                            break;
                        case 643:
                            label1.Text = ROMAN_643;
                            break;
                        case 644:
                            label1.Text = ROMAN_644;
                            break;
                        case 645:
                            label1.Text = ROMAN_645;
                            break;
                        case 646:
                            label1.Text = ROMAN_646;
                            break;
                        case 647:
                            label1.Text = ROMAN_647;
                            break;
                        case 648:
                            label1.Text = ROMAN_648;
                            break;
                        case 649:
                            label1.Text = ROMAN_649;
                            break;
                        case 650:
                            label1.Text = ROMAN_650;
                            break;

                        case 651:
                            label1.Text = ROMAN_651;
                            break;
                        case 652:
                            label1.Text = ROMAN_652;
                            break;
                        case 653:
                            label1.Text = ROMAN_653;
                            break;
                        case 654:
                            label1.Text = ROMAN_654;
                            break;
                        case 655:
                            label1.Text = ROMAN_655;
                            break;
                        case 656:
                            label1.Text = ROMAN_656;
                            break;
                        case 657:
                            label1.Text = ROMAN_657;
                            break;
                        case 658:
                            label1.Text = ROMAN_658;
                            break;
                        case 659:
                            label1.Text = ROMAN_659;
                            break;
                        case 660:
                            label1.Text = ROMAN_660;
                            break;
                        case 661:
                            label1.Text = ROMAN_661;
                            break;
                        case 662:
                            label1.Text = ROMAN_662;
                            break;
                        case 663:
                            label1.Text = ROMAN_663;
                            break;
                        case 664:
                            label1.Text = ROMAN_664;
                            break;
                        case 665:
                            label1.Text = ROMAN_665;
                            break;
                        case 666:
                            label1.Text = ROMAN_666;
                            break;
                        case 667:
                            label1.Text = ROMAN_667;
                            break;
                        case 668:
                            label1.Text = ROMAN_668;
                            break;
                        case 669:
                            label1.Text = ROMAN_669;
                            break;
                        case 670:
                            label1.Text = ROMAN_670;
                            break;

                        case 671:
                            label1.Text = ROMAN_671;
                            break;
                        case 672:
                            label1.Text = ROMAN_672;
                            break;
                        case 673:
                            label1.Text = ROMAN_673;
                            break;
                        case 674:
                            label1.Text = ROMAN_674;
                            break;
                        case 675:
                            label1.Text = ROMAN_675;
                            break;
                        case 676:
                            label1.Text = ROMAN_676;
                            break;
                        case 677:
                            label1.Text = ROMAN_677;
                            break;
                        case 678:
                            label1.Text = ROMAN_678;
                            break;
                        case 679:
                            label1.Text = ROMAN_679;
                            break;
                        case 680:
                            label1.Text = ROMAN_680;
                            break;

                        case 681:
                            label1.Text = ROMAN_681;
                            break;
                        case 682:
                            label1.Text = ROMAN_682;
                            break;
                        case 683:
                            label1.Text = ROMAN_683;
                            break;
                        case 684:
                            label1.Text = ROMAN_684;
                            break;
                        case 685:
                            label1.Text = ROMAN_685;
                            break;
                        case 686:
                            label1.Text = ROMAN_686;
                            break;
                        case 687:
                            label1.Text = ROMAN_687;
                            break;
                        case 688:
                            label1.Text = ROMAN_688;
                            break;
                        case 689:
                            label1.Text = ROMAN_689;
                            break;
                        case 690:
                            label1.Text = ROMAN_690;
                            break;

                        case 691:
                            label1.Text = ROMAN_691;
                            break;
                        case 692:
                            label1.Text = ROMAN_692;
                            break;
                        case 693:
                            label1.Text = ROMAN_693;
                            break;
                        case 694:
                            label1.Text = ROMAN_694;
                            break;
                        case 695:
                            label1.Text = ROMAN_695;
                            break;
                        case 696:
                            label1.Text = ROMAN_696;
                            break;
                        case 697:
                            label1.Text = ROMAN_697;
                            break;
                        case 698:
                            label1.Text = ROMAN_698;
                            break;
                        case 699:
                            label1.Text = ROMAN_699;
                            break;
                        case 700:
                            label1.Text = ROMAN_700;
                            break;
                        case 701:
                            label1.Text = ROMAN_701;
                            break;
                        case 702:
                            label1.Text = ROMAN_702;
                            break;
                        case 703:
                            label1.Text = ROMAN_703;
                            break;
                        case 704:
                            label1.Text = ROMAN_704;
                            break;
                        case 705:
                            label1.Text = ROMAN_705;
                            break;
                        case 706:
                            label1.Text = ROMAN_706;
                            break;
                        case 707:
                            label1.Text = ROMAN_707;
                            break;
                        case 708:
                            label1.Text = ROMAN_708;
                            break;
                        case 709:
                            label1.Text = ROMAN_709;
                            break;
                        case 710:
                            label1.Text = ROMAN_710;
                            break;
                        //               default:
                        //                   label1.Text = "Kun årstallene 1 - 2030";
                        //                  break;
                        case 711:
                            label1.Text = ROMAN_711;
                            break;
                        case 712:
                            label1.Text = ROMAN_712;
                            break;
                        case 713:
                            label1.Text = ROMAN_713;
                            break;
                        case 714:
                            label1.Text = ROMAN_714;
                            break;
                        case 715:
                            label1.Text = ROMAN_715;
                            break;
                        case 716:
                            label1.Text = ROMAN_716;
                            break;
                        case 717:
                            label1.Text = ROMAN_717;
                            break;
                        case 718:
                            label1.Text = ROMAN_718;
                            break;
                        case 719:
                            label1.Text = ROMAN_719;
                            break;
                        case 720:
                            label1.Text = ROMAN_720;
                            break;
                        case 721:
                            label1.Text = ROMAN_721;
                            break;
                        case 722:
                            label1.Text = ROMAN_722;
                            break;
                        case 723:
                            label1.Text = ROMAN_723;
                            break;
                        case 724:
                            label1.Text = ROMAN_724;
                            break;
                        case 725:
                            label1.Text = ROMAN_725;
                            break;
                        case 726:
                            label1.Text = ROMAN_726;
                            break;
                        case 727:
                            label1.Text = ROMAN_727;
                            break;
                        case 728:
                            label1.Text = ROMAN_728;
                            break;
                        case 729:
                            label1.Text = ROMAN_729;
                            break;
                        case 730:
                            label1.Text = ROMAN_730;
                            break;

                        case 731:
                            label1.Text = ROMAN_731;
                            break;
                        case 732:
                            label1.Text = ROMAN_732;
                            break;
                        case 733:
                            label1.Text = ROMAN_733;
                            break;
                        case 734:
                            label1.Text = ROMAN_734;
                            break;
                        case 735:
                            label1.Text = ROMAN_735;
                            break;
                        case 736:
                            label1.Text = ROMAN_736;
                            break;
                        case 737:
                            label1.Text = ROMAN_737;
                            break;
                        case 738:
                            label1.Text = ROMAN_738;
                            break;
                        case 739:
                            label1.Text = ROMAN_739;
                            break;
                        case 740:
                            label1.Text = ROMAN_740;
                            break;

                        case 741:
                            label1.Text = ROMAN_741;
                            break;
                        case 742:
                            label1.Text = ROMAN_742;
                            break;
                        case 743:
                            label1.Text = ROMAN_743;
                            break;
                        case 744:
                            label1.Text = ROMAN_744;
                            break;
                        case 745:
                            label1.Text = ROMAN_745;
                            break;
                        case 746:
                            label1.Text = ROMAN_746;
                            break;
                        case 747:
                            label1.Text = ROMAN_747;
                            break;
                        case 748:
                            label1.Text = ROMAN_748;
                            break;
                        case 749:
                            label1.Text = ROMAN_749;
                            break;
                        case 750:
                            label1.Text = ROMAN_750;
                            break;

                        case 751:
                            label1.Text = ROMAN_751;
                            break;
                        case 752:
                            label1.Text = ROMAN_752;
                            break;
                        case 753:
                            label1.Text = ROMAN_753;
                            break;
                        case 754:
                            label1.Text = ROMAN_754;
                            break;
                        case 755:
                            label1.Text = ROMAN_755;
                            break;
                        case 756:
                            label1.Text = ROMAN_756;
                            break;
                        case 757:
                            label1.Text = ROMAN_757;
                            break;
                        case 758:
                            label1.Text = ROMAN_758;
                            break;
                        case 759:
                            label1.Text = ROMAN_759;
                            break;
                        case 760:
                            label1.Text = ROMAN_760;
                            break;
                        case 761:
                            label1.Text = ROMAN_761;
                            break;
                        case 762:
                            label1.Text = ROMAN_762;
                            break;
                        case 763:
                            label1.Text = ROMAN_763;
                            break;
                        case 764:
                            label1.Text = ROMAN_764;
                            break;
                        case 765:
                            label1.Text = ROMAN_765;
                            break;
                        case 766:
                            label1.Text = ROMAN_766;
                            break;
                        case 767:
                            label1.Text = ROMAN_767;
                            break;
                        case 768:
                            label1.Text = ROMAN_768;
                            break;
                        case 769:
                            label1.Text = ROMAN_769;
                            break;
                        case 770:
                            label1.Text = ROMAN_770;
                            break;

                        case 771:
                            label1.Text = ROMAN_771;
                            break;
                        case 772:
                            label1.Text = ROMAN_772;
                            break;
                        case 773:
                            label1.Text = ROMAN_773;
                            break;
                        case 774:
                            label1.Text = ROMAN_774;
                            break;
                        case 775:
                            label1.Text = ROMAN_775;
                            break;
                        case 776:
                            label1.Text = ROMAN_776;
                            break;
                        case 777:
                            label1.Text = ROMAN_777;
                            break;
                        case 778:
                            label1.Text = ROMAN_778;
                            break;
                        case 779:
                            label1.Text = ROMAN_779;
                            break;
                        case 780:
                            label1.Text = ROMAN_780;
                            break;

                        case 781:
                            label1.Text = ROMAN_781;
                            break;
                        case 782:
                            label1.Text = ROMAN_782;
                            break;
                        case 783:
                            label1.Text = ROMAN_783;
                            break;
                        case 784:
                            label1.Text = ROMAN_784;
                            break;
                        case 785:
                            label1.Text = ROMAN_785;
                            break;
                        case 786:
                            label1.Text = ROMAN_786;
                            break;
                        case 787:
                            label1.Text = ROMAN_787;
                            break;
                        case 788:
                            label1.Text = ROMAN_788;
                            break;
                        case 789:
                            label1.Text = ROMAN_789;
                            break;
                        case 790:
                            label1.Text = ROMAN_790;
                            break;

                        case 791:
                            label1.Text = ROMAN_791;
                            break;
                        case 792:
                            label1.Text = ROMAN_792;
                            break;
                        case 793:
                            label1.Text = ROMAN_793;
                            break;
                        case 794:
                            label1.Text = ROMAN_794;
                            break;
                        case 795:
                            label1.Text = ROMAN_795;
                            break;
                        case 796:
                            label1.Text = ROMAN_796;
                            break;
                        case 797:
                            label1.Text = ROMAN_797;
                            break;
                        case 798:
                            label1.Text = ROMAN_798;
                            break;
                        case 799:
                            label1.Text = ROMAN_799;
                            break;
                        case 800:
                            label1.Text = ROMAN_800;
                            break;
                        case 801:
                            label1.Text = ROMAN_801;
                            break;
                        case 802:
                            label1.Text = ROMAN_802;
                            break;
                        case 803:
                            label1.Text = ROMAN_803;
                            break;
                        case 804:
                            label1.Text = ROMAN_804;
                            break;
                        case 805:
                            label1.Text = ROMAN_805;
                            break;
                        case 806:
                            label1.Text = ROMAN_806;
                            break;
                        case 807:
                            label1.Text = ROMAN_807;
                            break;
                        case 808:
                            label1.Text = ROMAN_808;
                            break;
                        case 809:
                            label1.Text = ROMAN_809;
                            break;
                        case 810:
                            label1.Text = ROMAN_810;
                            break;
                        //               default:
                        //                   label1.Text = "Kun årstallene 1 - 2030";
                        //                  break;
                        case 811:
                            label1.Text = ROMAN_811;
                            break;
                        case 812:
                            label1.Text = ROMAN_812;
                            break;
                        case 813:
                            label1.Text = ROMAN_813;
                            break;
                        case 814:
                            label1.Text = ROMAN_814;
                            break;
                        case 815:
                            label1.Text = ROMAN_815;
                            break;
                        case 816:
                            label1.Text = ROMAN_816;
                            break;
                        case 817:
                            label1.Text = ROMAN_817;
                            break;
                        case 818:
                            label1.Text = ROMAN_818;
                            break;
                        case 819:
                            label1.Text = ROMAN_819;
                            break;
                        case 820:
                            label1.Text = ROMAN_820;
                            break;
                        case 821:
                            label1.Text = ROMAN_821;
                            break;
                        case 822:
                            label1.Text = ROMAN_822;
                            break;
                        case 823:
                            label1.Text = ROMAN_823;
                            break;
                        case 824:
                            label1.Text = ROMAN_824;
                            break;
                        case 825:
                            label1.Text = ROMAN_825;
                            break;
                        case 826:
                            label1.Text = ROMAN_826;
                            break;
                        case 827:
                            label1.Text = ROMAN_827;
                            break;
                        case 828:
                            label1.Text = ROMAN_828;
                            break;
                        case 829:
                            label1.Text = ROMAN_829;
                            break;
                        case 830:
                            label1.Text = ROMAN_830;
                            break;

                        case 831:
                            label1.Text = ROMAN_831;
                            break;
                        case 832:
                            label1.Text = ROMAN_832;
                            break;
                        case 833:
                            label1.Text = ROMAN_833;
                            break;
                        case 834:
                            label1.Text = ROMAN_834;
                            break;
                        case 835:
                            label1.Text = ROMAN_835;
                            break;
                        case 836:
                            label1.Text = ROMAN_836;
                            break;
                        case 837:
                            label1.Text = ROMAN_837;
                            break;
                        case 838:
                            label1.Text = ROMAN_838;
                            break;
                        case 839:
                            label1.Text = ROMAN_839;
                            break;
                        case 840:
                            label1.Text = ROMAN_840;
                            break;

                        case 841:
                            label1.Text = ROMAN_841;
                            break;
                        case 842:
                            label1.Text = ROMAN_842;
                            break;
                        case 843:
                            label1.Text = ROMAN_843;
                            break;
                        case 844:
                            label1.Text = ROMAN_844;
                            break;
                        case 845:
                            label1.Text = ROMAN_845;
                            break;
                        case 846:
                            label1.Text = ROMAN_846;
                            break;
                        case 847:
                            label1.Text = ROMAN_847;
                            break;
                        case 848:
                            label1.Text = ROMAN_848;
                            break;
                        case 849:
                            label1.Text = ROMAN_849;
                            break;
                        case 850:
                            label1.Text = ROMAN_850;
                            break;

                        case 851:
                            label1.Text = ROMAN_851;
                            break;
                        case 852:
                            label1.Text = ROMAN_852;
                            break;
                        case 853:
                            label1.Text = ROMAN_853;
                            break;
                        case 854:
                            label1.Text = ROMAN_854;
                            break;
                        case 855:
                            label1.Text = ROMAN_855;
                            break;
                        case 856:
                            label1.Text = ROMAN_856;
                            break;
                        case 857:
                            label1.Text = ROMAN_857;
                            break;
                        case 858:
                            label1.Text = ROMAN_858;
                            break;
                        case 859:
                            label1.Text = ROMAN_859;
                            break;
                        case 860:
                            label1.Text = ROMAN_860;
                            break;
                        case 861:
                            label1.Text = ROMAN_861;
                            break;
                        case 862:
                            label1.Text = ROMAN_862;
                            break;
                        case 863:
                            label1.Text = ROMAN_863;
                            break;
                        case 864:
                            label1.Text = ROMAN_864;
                            break;
                        case 865:
                            label1.Text = ROMAN_865;
                            break;
                        case 866:
                            label1.Text = ROMAN_866;
                            break;
                        case 867:
                            label1.Text = ROMAN_867;
                            break;
                        case 868:
                            label1.Text = ROMAN_868;
                            break;
                        case 869:
                            label1.Text = ROMAN_869;
                            break;
                        case 870:
                            label1.Text = ROMAN_870;
                            break;

                        case 871:
                            label1.Text = ROMAN_871;
                            break;
                        case 872:
                            label1.Text = ROMAN_872;
                            break;
                        case 873:
                            label1.Text = ROMAN_873;
                            break;
                        case 874:
                            label1.Text = ROMAN_874;
                            break;
                        case 875:
                            label1.Text = ROMAN_875;
                            break;
                        case 876:
                            label1.Text = ROMAN_876;
                            break;
                        case 877:
                            label1.Text = ROMAN_877;
                            break;
                        case 878:
                            label1.Text = ROMAN_878;
                            break;
                        case 879:
                            label1.Text = ROMAN_879;
                            break;
                        case 880:
                            label1.Text = ROMAN_880;
                            break;

                        case 881:
                            label1.Text = ROMAN_881;
                            break;
                        case 882:
                            label1.Text = ROMAN_882;
                            break;
                        case 883:
                            label1.Text = ROMAN_883;
                            break;
                        case 884:
                            label1.Text = ROMAN_884;
                            break;
                        case 885:
                            label1.Text = ROMAN_885;
                            break;
                        case 886:
                            label1.Text = ROMAN_886;
                            break;
                        case 887:
                            label1.Text = ROMAN_887;
                            break;
                        case 888:
                            label1.Text = ROMAN_888;
                            break;
                        case 889:
                            label1.Text = ROMAN_889;
                            break;
                        case 890:
                            label1.Text = ROMAN_890;
                            break;

                        case 891:
                            label1.Text = ROMAN_891;
                            break;
                        case 892:
                            label1.Text = ROMAN_892;
                            break;
                        case 893:
                            label1.Text = ROMAN_893;
                            break;
                        case 894:
                            label1.Text = ROMAN_894;
                            break;
                        case 895:
                            label1.Text = ROMAN_895;
                            break;
                        case 896:
                            label1.Text = ROMAN_896;
                            break;
                        case 897:
                            label1.Text = ROMAN_897;
                            break;
                        case 898:
                            label1.Text = ROMAN_898;
                            break;
                        case 899:
                            label1.Text = ROMAN_899;
                            break;
                        case 900:
                            label1.Text = ROMAN_900;
                            break;

                        case 901:
                            label1.Text = ROMAN_901;
                            break;
                        case 902:
                            label1.Text = ROMAN_902;
                            break;
                        case 903:
                            label1.Text = ROMAN_903;
                            break;
                        case 9094:
                            label1.Text = ROMAN_904;
                            break;
                        case 905:
                            label1.Text = ROMAN_905;
                            break;
                        case 906:
                            label1.Text = ROMAN_906;
                            break;
                        case 907:
                            label1.Text = ROMAN_907;
                            break;
                        case 908:
                            label1.Text = ROMAN_908;
                            break;
                        case 909:
                            label1.Text = ROMAN_909;
                            break;
                        case 910:
                            label1.Text = ROMAN_910;
                            break;
                        //               default:
                        //                   label1.Text = "Kun årstallene 1 - 2030";
                        //                  break;
                        case 911:
                            label1.Text = ROMAN_911;
                            break;
                        case 912:
                            label1.Text = ROMAN_912;
                            break;
                        case 913:
                            label1.Text = ROMAN_913;
                            break;
                        case 914:
                            label1.Text = ROMAN_914;
                            break;
                        case 915:
                            label1.Text = ROMAN_915;
                            break;
                        case 916:
                            label1.Text = ROMAN_916;
                            break;
                        case 917:
                            label1.Text = ROMAN_917;
                            break;
                        case 918:
                            label1.Text = ROMAN_918;
                            break;
                        case 919:
                            label1.Text = ROMAN_919;
                            break;
                        case 920:
                            label1.Text = ROMAN_920;
                            break;
                        case 921:
                            label1.Text = ROMAN_921;
                            break;
                        case 922:
                            label1.Text = ROMAN_922;
                            break;
                        case 923:
                            label1.Text = ROMAN_923;
                            break;
                        case 924:
                            label1.Text = ROMAN_924;
                            break;
                        case 925:
                            label1.Text = ROMAN_925;
                            break;
                        case 926:
                            label1.Text = ROMAN_926;
                            break;
                        case 927:
                            label1.Text = ROMAN_927;
                            break;
                        case 928:
                            label1.Text = ROMAN_928;
                            break;
                        case 929:
                            label1.Text = ROMAN_929;
                            break;
                        case 930:
                            label1.Text = ROMAN_930;
                            break;

                        case 931:
                            label1.Text = ROMAN_931;
                            break;
                        case 932:
                            label1.Text = ROMAN_932;
                            break;
                        case 933:
                            label1.Text = ROMAN_933;
                            break;
                        case 934:
                            label1.Text = ROMAN_934;
                            break;
                        case 935:
                            label1.Text = ROMAN_935;
                            break;
                        case 936:
                            label1.Text = ROMAN_936;
                            break;
                        case 937:
                            label1.Text = ROMAN_937;
                            break;
                        case 938:
                            label1.Text = ROMAN_938;
                            break;
                        case 939:
                            label1.Text = ROMAN_939;
                            break;
                        case 940:
                            label1.Text = ROMAN_940;
                            break;

                        case 941:
                            label1.Text = ROMAN_941;
                            break;
                        case 942:
                            label1.Text = ROMAN_942;
                            break;
                        case 943:
                            label1.Text = ROMAN_943;
                            break;
                        case 944:
                            label1.Text = ROMAN_944;
                            break;
                        case 945:
                            label1.Text = ROMAN_945;
                            break;
                        case 946:
                            label1.Text = ROMAN_946;
                            break;
                        case 947:
                            label1.Text = ROMAN_947;
                            break;
                        case 948:
                            label1.Text = ROMAN_948;
                            break;
                        case 949:
                            label1.Text = ROMAN_949;
                            break;
                        case 950:
                            label1.Text = ROMAN_950;
                            break;

                        case 951:
                            label1.Text = ROMAN_951;
                            break;
                        case 952:
                            label1.Text = ROMAN_952;
                            break;
                        case 953:
                            label1.Text = ROMAN_953;
                            break;
                        case 954:
                            label1.Text = ROMAN_954;
                            break;
                        case 955:
                            label1.Text = ROMAN_955;
                            break;
                        case 956:
                            label1.Text = ROMAN_956;
                            break;
                        case 957:
                            label1.Text = ROMAN_957;
                            break;
                        case 958:
                            label1.Text = ROMAN_958;
                            break;
                        case 959:
                            label1.Text = ROMAN_959;
                            break;
                        case 960:
                            label1.Text = ROMAN_960;
                            break;
                        case 961:
                            label1.Text = ROMAN_961;
                            break;
                        case 962:
                            label1.Text = ROMAN_962;
                            break;
                        case 963:
                            label1.Text = ROMAN_963;
                            break;
                        case 964:
                            label1.Text = ROMAN_964;
                            break;
                        case 965:
                            label1.Text = ROMAN_965;
                            break;
                        case 966:
                            label1.Text = ROMAN_966;
                            break;
                        case 967:
                            label1.Text = ROMAN_967;
                            break;
                        case 968:
                            label1.Text = ROMAN_968;
                            break;
                        case 969:
                            label1.Text = ROMAN_969;
                            break;
                        case 970:
                            label1.Text = ROMAN_970;
                            break;

                        case 971:
                            label1.Text = ROMAN_971;
                            break;
                        case 972:
                            label1.Text = ROMAN_972;
                            break;
                        case 973:
                            label1.Text = ROMAN_973;
                            break;
                        case 974:
                            label1.Text = ROMAN_974;
                            break;
                        case 975:
                            label1.Text = ROMAN_975;
                            break;
                        case 976:
                            label1.Text = ROMAN_976;
                            break;
                        case 977:
                            label1.Text = ROMAN_977;
                            break;
                        case 978:
                            label1.Text = ROMAN_978;
                            break;
                        case 979:
                            label1.Text = ROMAN_979;
                            break;
                        case 980:
                            label1.Text = ROMAN_980;
                            break;

                        case 981:
                            label1.Text = ROMAN_981;
                            break;
                        case 982:
                            label1.Text = ROMAN_982;
                            break;
                        case 983:
                            label1.Text = ROMAN_983;
                            break;
                        case 984:
                            label1.Text = ROMAN_984;
                            break;
                        case 985:
                            label1.Text = ROMAN_985;
                            break;
                        case 986:
                            label1.Text = ROMAN_986;
                            break;
                        case 987:
                            label1.Text = ROMAN_987;
                            break;
                        case 988:
                            label1.Text = ROMAN_988;
                            break;
                        case 989:
                            label1.Text = ROMAN_989;
                            break;
                        case 990:
                            label1.Text = ROMAN_990;
                            break;

                        case 991:
                            label1.Text = ROMAN_991;
                            break;
                        case 992:
                            label1.Text = ROMAN_992;
                            break;
                        case 993:
                            label1.Text = ROMAN_993;
                            break;
                        case 994:
                            label1.Text = ROMAN_994;
                            break;
                        case 995:
                            label1.Text = ROMAN_995;
                            break;
                        case 996:
                            label1.Text = ROMAN_996;
                            break;
                        case 997:
                            label1.Text = ROMAN_997;
                            break;
                        case 998:
                            label1.Text = ROMAN_998;
                            break;
                        case 999:
                            label1.Text = ROMAN_999;
                            break;
                        case 1000:
                            label1.Text = ROMAN_1000;
                            break;

                        case 1001:
                            label1.Text = ROMAN_1001;
                            break;
                        case 1002:
                            label1.Text = ROMAN_1002;
                            break;
                        case 1003:
                            label1.Text = ROMAN_1003;
                            break;
                        case 1004:
                            label1.Text = ROMAN_1004;
                            break;
                        case 1005:
                            label1.Text = ROMAN_1005;
                            break;
                        case 1006:
                            label1.Text = ROMAN_1006;
                            break;
                        case 1007:
                            label1.Text = ROMAN_1007;
                            break;
                        case 1008:
                            label1.Text = ROMAN_1008;
                            break;
                        case 1009:
                            label1.Text = ROMAN_1009;
                            break;
                        case 1010:
                            label1.Text = ROMAN_1010;
                            break;
                        //               default:
                        //                   label1.Text = "Kun årstallene 1 - 2030";
                        //                  break;
                        case 1011:
                            label1.Text = ROMAN_1011;
                            break;
                        case 1012:
                            label1.Text = ROMAN_1012;
                            break;
                        case 1013:
                            label1.Text = ROMAN_1013;
                            break;
                        case 1014:
                            label1.Text = ROMAN_1014;
                            break;
                        case 1015:
                            label1.Text = ROMAN_1015;
                            break;
                        case 1016:
                            label1.Text = ROMAN_1016;
                            break;
                        case 1017:
                            label1.Text = ROMAN_1017;
                            break;
                        case 1018:
                            label1.Text = ROMAN_1018;
                            break;
                        case 1019:
                            label1.Text = ROMAN_1019;
                            break;
                        case 1020:
                            label1.Text = ROMAN_1020;
                            break;
                        case 1021:
                            label1.Text = ROMAN_1021;
                            break;
                        case 1022:
                            label1.Text = ROMAN_1022;
                            break;
                        case 1023:
                            label1.Text = ROMAN_1023;
                            break;
                        case 1024:
                            label1.Text = ROMAN_1024;
                            break;
                        case 1025:
                            label1.Text = ROMAN_1025;
                            break;
                        case 1026:
                            label1.Text = ROMAN_1026;
                            break;
                        case 1027:
                            label1.Text = ROMAN_1027;
                            break;
                        case 1028:
                            label1.Text = ROMAN_1028;
                            break;
                        case 1029:
                            label1.Text = ROMAN_1029;
                            break;
                        case 1030:
                            label1.Text = ROMAN_1030;
                            break;

                        case 1031:
                            label1.Text = ROMAN_1031;
                            break;
                        case 1032:
                            label1.Text = ROMAN_1032;
                            break;
                        case 1033:
                            label1.Text = ROMAN_1033;
                            break;
                        case 1034:
                            label1.Text = ROMAN_1034;
                            break;
                        case 1035:
                            label1.Text = ROMAN_1035;
                            break;
                        case 1036:
                            label1.Text = ROMAN_1036;
                            break;
                        case 1037:
                            label1.Text = ROMAN_1037;
                            break;
                        case 1038:
                            label1.Text = ROMAN_1038;
                            break;
                        case 1039:
                            label1.Text = ROMAN_1039;
                            break;
                        case 1040:
                            label1.Text = ROMAN_1040;
                            break;

                        case 1041:
                            label1.Text = ROMAN_1041;
                            break;
                        case 1042:
                            label1.Text = ROMAN_1042;
                            break;
                        case 1043:
                            label1.Text = ROMAN_1043;
                            break;
                        case 1044:
                            label1.Text = ROMAN_1044;
                            break;
                        case 1045:
                            label1.Text = ROMAN_1045;
                            break;
                        case 1046:
                            label1.Text = ROMAN_1046;
                            break;
                        case 1047:
                            label1.Text = ROMAN_1047;
                            break;
                        case 1048:
                            label1.Text = ROMAN_1048;
                            break;
                        case 1049:
                            label1.Text = ROMAN_1049;
                            break;
                        case 1050:
                            label1.Text = ROMAN_1050;
                            break;

                        case 1051:
                            label1.Text = ROMAN_1051;
                            break;
                        case 1052:
                            label1.Text = ROMAN_1052;
                            break;
                        case 1053:
                            label1.Text = ROMAN_1053;
                            break;
                        case 1054:
                            label1.Text = ROMAN_1054;
                            break;
                        case 1055:
                            label1.Text = ROMAN_1055;
                            break;
                        case 1056:
                            label1.Text = ROMAN_1056;
                            break;
                        case 1057:
                            label1.Text = ROMAN_1057;
                            break;
                        case 1058:
                            label1.Text = ROMAN_1058;
                            break;
                        case 1059:
                            label1.Text = ROMAN_1059;
                            break;
                        case 1060:
                            label1.Text = ROMAN_1060;
                            break;
                        case 1061:
                            label1.Text = ROMAN_1061;
                            break;
                        case 1062:
                            label1.Text = ROMAN_1062;
                            break;
                        case 1063:
                            label1.Text = ROMAN_1063;
                            break;
                        case 1064:
                            label1.Text = ROMAN_1064;
                            break;
                        case 1065:
                            label1.Text = ROMAN_1065;
                            break;
                        case 1066:
                            label1.Text = ROMAN_1066;
                            break;
                        case 1067:
                            label1.Text = ROMAN_1067;
                            break;
                        case 1068:
                            label1.Text = ROMAN_1068;
                            break;
                        case 1069:
                            label1.Text = ROMAN_1069;
                            break;
                        case 1070:
                            label1.Text = ROMAN_1070;
                            break;

                        case 1071:
                            label1.Text = ROMAN_1071;
                            break;
                        case 1072:
                            label1.Text = ROMAN_1072;
                            break;
                        case 1073:
                            label1.Text = ROMAN_1073;
                            break;
                        case 1074:
                            label1.Text = ROMAN_1074;
                            break;
                        case 1075:
                            label1.Text = ROMAN_1075;
                            break;
                        case 1076:
                            label1.Text = ROMAN_1076;
                            break;
                        case 1077:
                            label1.Text = ROMAN_1077;
                            break;
                        case 1078:
                            label1.Text = ROMAN_1078;
                            break;
                        case 1079:
                            label1.Text = ROMAN_1079;
                            break;
                        case 1080:
                            label1.Text = ROMAN_1080;
                            break;

                        case 1081:
                            label1.Text = ROMAN_1081;
                            break;
                        case 1082:
                            label1.Text = ROMAN_1082;
                            break;
                        case 1083:
                            label1.Text = ROMAN_1083;
                            break;
                        case 1084:
                            label1.Text = ROMAN_1084;
                            break;
                        case 1085:
                            label1.Text = ROMAN_1085;
                            break;
                        case 1086:
                            label1.Text = ROMAN_1086;
                            break;
                        case 1087:
                            label1.Text = ROMAN_1087;
                            break;
                        case 1088:
                            label1.Text = ROMAN_1088;
                            break;
                        case 1089:
                            label1.Text = ROMAN_1089;
                            break;
                        case 1090:
                            label1.Text = ROMAN_1090;
                            break;

                        case 1091:
                            label1.Text = ROMAN_1091;
                            break;
                        case 1092:
                            label1.Text = ROMAN_1092;
                            break;
                        case 1093:
                            label1.Text = ROMAN_1093;
                            break;
                        case 1094:
                            label1.Text = ROMAN_1094;
                            break;
                        case 1095:
                            label1.Text = ROMAN_1095;
                            break;
                        case 1096:
                            label1.Text = ROMAN_1096;
                            break;
                        case 1097:
                            label1.Text = ROMAN_1097;
                            break;
                        case 1098:
                            label1.Text = ROMAN_1098;
                            break;
                        case 1099:
                            label1.Text = ROMAN_1099;
                            break;
                        case 1100:
                            label1.Text = ROMAN_1100;
                            break;
                        case 1101:
                            label1.Text = ROMAN_1101;
                            break;
                        case 1102:
                            label1.Text = ROMAN_1102;
                            break;
                        case 1103:
                            label1.Text = ROMAN_1103;
                            break;
                        case 1104:
                            label1.Text = ROMAN_1104;
                            break;
                        case 1105:
                            label1.Text = ROMAN_1105;
                            break;
                        case 1106:
                            label1.Text = ROMAN_1106;
                            break;
                        case 1107:
                            label1.Text = ROMAN_1107;
                            break;
                        case 1108:
                            label1.Text = ROMAN_1108;
                            break;
                        case 1109:
                            label1.Text = ROMAN_1109;
                            break;
                        case 1110:
                            label1.Text = ROMAN_1110;
                            break;
                        //               default:
                        //                   label1.Text = "Kun årstallene 1 - 2030";
                        //                  break;
                        case 1111:
                            label1.Text = ROMAN_1111;
                            break;
                        case 1112:
                            label1.Text = ROMAN_1112;
                            break;
                        case 1113:
                            label1.Text = ROMAN_1113;
                            break;
                        case 1114:
                            label1.Text = ROMAN_1114;
                            break;
                        case 1115:
                            label1.Text = ROMAN_1115;
                            break;
                        case 1116:
                            label1.Text = ROMAN_1116;
                            break;
                        case 1117:
                            label1.Text = ROMAN_1117;
                            break;
                        case 1118:
                            label1.Text = ROMAN_1118;
                            break;
                        case 1119:
                            label1.Text = ROMAN_1119;
                            break;
                        case 1120:
                            label1.Text = ROMAN_1120;
                            break;
                        case 1121:
                            label1.Text = ROMAN_1121;
                            break;
                        case 1122:
                            label1.Text = ROMAN_1122;
                            break;
                        case 1123:
                            label1.Text = ROMAN_1123;
                            break;
                        case 1124:
                            label1.Text = ROMAN_1124;
                            break;
                        case 1125:
                            label1.Text = ROMAN_1125;
                            break;
                        case 1126:
                            label1.Text = ROMAN_1126;
                            break;
                        case 1127:
                            label1.Text = ROMAN_1127;
                            break;
                        case 1128:
                            label1.Text = ROMAN_1128;
                            break;
                        case 1129:
                            label1.Text = ROMAN_1129;
                            break;
                        case 1130:
                            label1.Text = ROMAN_1130;
                            break;

                        case 1131:
                            label1.Text = ROMAN_1131;
                            break;
                        case 1132:
                            label1.Text = ROMAN_1132;
                            break;
                        case 1133:
                            label1.Text = ROMAN_1133;
                            break;
                        case 1134:
                            label1.Text = ROMAN_1134;
                            break;
                        case 1135:
                            label1.Text = ROMAN_1135;
                            break;
                        case 1136:
                            label1.Text = ROMAN_1136;
                            break;
                        case 1137:
                            label1.Text = ROMAN_1137;
                            break;
                        case 1138:
                            label1.Text = ROMAN_1138;
                            break;
                        case 1139:
                            label1.Text = ROMAN_1139;
                            break;
                        case 1140:
                            label1.Text = ROMAN_1140;
                            break;

                        case 1141:
                            label1.Text = ROMAN_1141;
                            break;
                        case 1142:
                            label1.Text = ROMAN_1142;
                            break;
                        case 1143:
                            label1.Text = ROMAN_1143;
                            break;
                        case 1144:
                            label1.Text = ROMAN_1144;
                            break;
                        case 1145:
                            label1.Text = ROMAN_1145;
                            break;
                        case 1146:
                            label1.Text = ROMAN_1146;
                            break;
                        case 1147:
                            label1.Text = ROMAN_1147;
                            break;
                        case 1148:
                            label1.Text = ROMAN_1148;
                            break;
                        case 1149:
                            label1.Text = ROMAN_1149;
                            break;
                        case 1150:
                            label1.Text = ROMAN_1150;
                            break;

                        case 1151:
                            label1.Text = ROMAN_1151;
                            break;
                        case 1152:
                            label1.Text = ROMAN_1152;
                            break;
                        case 1153:
                            label1.Text = ROMAN_1153;
                            break;
                        case 1154:
                            label1.Text = ROMAN_1154;
                            break;
                        case 1155:
                            label1.Text = ROMAN_1155;
                            break;
                        case 1156:
                            label1.Text = ROMAN_1156;
                            break;
                        case 1157:
                            label1.Text = ROMAN_1157;
                            break;
                        case 1158:
                            label1.Text = ROMAN_1158;
                            break;
                        case 1159:
                            label1.Text = ROMAN_1159;
                            break;
                        case 1160:
                            label1.Text = ROMAN_1160;
                            break;
                        case 1161:
                            label1.Text = ROMAN_1161;
                            break;
                        case 1162:
                            label1.Text = ROMAN_1162;
                            break;
                        case 1163:
                            label1.Text = ROMAN_1163;
                            break;
                        case 1164:
                            label1.Text = ROMAN_1164;
                            break;
                        case 1165:
                            label1.Text = ROMAN_1165;
                            break;
                        case 1166:
                            label1.Text = ROMAN_1166;
                            break;
                        case 1167:
                            label1.Text = ROMAN_1167;
                            break;
                        case 1168:
                            label1.Text = ROMAN_1168;
                            break;
                        case 1169:
                            label1.Text = ROMAN_1169;
                            break;
                        case 1170:
                            label1.Text = ROMAN_1170;
                            break;

                        case 1171:
                            label1.Text = ROMAN_1171;
                            break;
                        case 1172:
                            label1.Text = ROMAN_1172;
                            break;
                        case 1173:
                            label1.Text = ROMAN_1173;
                            break;
                        case 1174:
                            label1.Text = ROMAN_1174;
                            break;
                        case 1175:
                            label1.Text = ROMAN_1175;
                            break;
                        case 1176:
                            label1.Text = ROMAN_1176;
                            break;
                        case 1177:
                            label1.Text = ROMAN_1177;
                            break;
                        case 1178:
                            label1.Text = ROMAN_1178;
                            break;
                        case 1179:
                            label1.Text = ROMAN_1179;
                            break;
                        case 1180:
                            label1.Text = ROMAN_1180;
                            break;

                        case 1181:
                            label1.Text = ROMAN_1181;
                            break;
                        case 1182:
                            label1.Text = ROMAN_1182;
                            break;
                        case 1183:
                            label1.Text = ROMAN_1183;
                            break;
                        case 1184:
                            label1.Text = ROMAN_1184;
                            break;
                        case 1185:
                            label1.Text = ROMAN_1185;
                            break;
                        case 1186:
                            label1.Text = ROMAN_1186;
                            break;
                        case 1187:
                            label1.Text = ROMAN_1187;
                            break;
                        case 1188:
                            label1.Text = ROMAN_1188;
                            break;
                        case 1189:
                            label1.Text = ROMAN_1189;
                            break;
                        case 1190:
                            label1.Text = ROMAN_1190;
                            break;

                        case 1191:
                            label1.Text = ROMAN_1191;
                            break;
                        case 1192:
                            label1.Text = ROMAN_1192;
                            break;
                        case 1193:
                            label1.Text = ROMAN_1193;
                            break;
                        case 1194:
                            label1.Text = ROMAN_1194;
                            break;
                        case 1195:
                            label1.Text = ROMAN_1195;
                            break;
                        case 1196:
                            label1.Text = ROMAN_1196;
                            break;
                        case 1197:
                            label1.Text = ROMAN_1197;
                            break;
                        case 1198:
                            label1.Text = ROMAN_1198;
                            break;
                        case 1199:
                            label1.Text = ROMAN_1199;
                            break;
                        case 1200:
                            label1.Text = ROMAN_1200;
                            break;
                        case 1201:
                            label1.Text = ROMAN_1201;
                            break;
                        case 1202:
                            label1.Text = ROMAN_1202;
                            break;
                        case 1203:
                            label1.Text = ROMAN_1203;
                            break;
                        case 1204:
                            label1.Text = ROMAN_1204;
                            break;
                        case 1205:
                            label1.Text = ROMAN_1205;
                            break;
                        case 1206:
                            label1.Text = ROMAN_1206;
                            break;
                        case 1207:
                            label1.Text = ROMAN_1207;
                            break;
                        case 1208:
                            label1.Text = ROMAN_1208;
                            break;
                        case 1209:
                            label1.Text = ROMAN_1209;
                            break;
                        case 1210:
                            label1.Text = ROMAN_1210;
                            break;
                        //               default:
                        //                   label1.Text = "Kun årstallene 1 - 2030";
                        //                  break;
                        case 1211:
                            label1.Text = ROMAN_1211;
                            break;
                        case 1212:
                            label1.Text = ROMAN_1212;
                            break;
                        case 1213:
                            label1.Text = ROMAN_1213;
                            break;
                        case 1214:
                            label1.Text = ROMAN_1214;
                            break;
                        case 1215:
                            label1.Text = ROMAN_1215;
                            break;
                        case 1216:
                            label1.Text = ROMAN_1216;
                            break;
                        case 1217:
                            label1.Text = ROMAN_1217;
                            break;
                        case 1218:
                            label1.Text = ROMAN_1218;
                            break;
                        case 1219:
                            label1.Text = ROMAN_1219;
                            break;
                        case 1220:
                            label1.Text = ROMAN_1220;
                            break;
                        case 1221:
                            label1.Text = ROMAN_1221;
                            break;
                        case 1222:
                            label1.Text = ROMAN_1222;
                            break;
                        case 1223:
                            label1.Text = ROMAN_1223;
                            break;
                        case 1224:
                            label1.Text = ROMAN_1224;
                            break;
                        case 1225:
                            label1.Text = ROMAN_1225;
                            break;
                        case 1226:
                            label1.Text = ROMAN_1226;
                            break;
                        case 1227:
                            label1.Text = ROMAN_1227;
                            break;
                        case 1228:
                            label1.Text = ROMAN_1228;
                            break;
                        case 1229:
                            label1.Text = ROMAN_1229;
                            break;
                        case 1230:
                            label1.Text = ROMAN_1230;
                            break;

                        case 1231:
                            label1.Text = ROMAN_1231;
                            break;
                        case 1232:
                            label1.Text = ROMAN_1232;
                            break;
                        case 1233:
                            label1.Text = ROMAN_1233;
                            break;
                        case 1234:
                            label1.Text = ROMAN_1234;
                            break;
                        case 1235:
                            label1.Text = ROMAN_1235;
                            break;
                        case 1236:
                            label1.Text = ROMAN_1236;
                            break;
                        case 1237:
                            label1.Text = ROMAN_1237;
                            break;
                        case 1238:
                            label1.Text = ROMAN_1238;
                            break;
                        case 1239:
                            label1.Text = ROMAN_1239;
                            break;
                        case 1240:
                            label1.Text = ROMAN_1240;
                            break;

                        case 1241:
                            label1.Text = ROMAN_1241;
                            break;
                        case 1242:
                            label1.Text = ROMAN_1242;
                            break;
                        case 1243:
                            label1.Text = ROMAN_1243;
                            break;
                        case 1244:
                            label1.Text = ROMAN_1244;
                            break;
                        case 1245:
                            label1.Text = ROMAN_1245;
                            break;
                        case 1246:
                            label1.Text = ROMAN_1246;
                            break;
                        case 1247:
                            label1.Text = ROMAN_1247;
                            break;
                        case 1248:
                            label1.Text = ROMAN_1248;
                            break;
                        case 1249:
                            label1.Text = ROMAN_1249;
                            break;
                        case 1250:
                            label1.Text = ROMAN_1250;
                            break;

                        case 1251:
                            label1.Text = ROMAN_1251;
                            break;
                        case 1252:
                            label1.Text = ROMAN_1252;
                            break;
                        case 1253:
                            label1.Text = ROMAN_1253;
                            break;
                        case 1254:
                            label1.Text = ROMAN_1254;
                            break;
                        case 1255:
                            label1.Text = ROMAN_1255;
                            break;
                        case 1256:
                            label1.Text = ROMAN_1256;
                            break;
                        case 1257:
                            label1.Text = ROMAN_1257;
                            break;
                        case 1258:
                            label1.Text = ROMAN_1258;
                            break;
                        case 1259:
                            label1.Text = ROMAN_1259;
                            break;
                        case 1260:
                            label1.Text = ROMAN_1260;
                            break;
                        case 1261:
                            label1.Text = ROMAN_1261;
                            break;
                        case 1262:
                            label1.Text = ROMAN_1262;
                            break;
                        case 1263:
                            label1.Text = ROMAN_1263;
                            break;
                        case 1264:
                            label1.Text = ROMAN_1264;
                            break;
                        case 1265:
                            label1.Text = ROMAN_1265;
                            break;
                        case 1266:
                            label1.Text = ROMAN_1266;
                            break;
                        case 1267:
                            label1.Text = ROMAN_1267;
                            break;
                        case 1268:
                            label1.Text = ROMAN_1268;
                            break;
                        case 1269:
                            label1.Text = ROMAN_1269;
                            break;
                        case 1270:
                            label1.Text = ROMAN_1270;
                            break;

                        case 1271:
                            label1.Text = ROMAN_1271;
                            break;
                        case 1272:
                            label1.Text = ROMAN_1272;
                            break;
                        case 11273:
                            label1.Text = ROMAN_1273;
                            break;
                        case 1274:
                            label1.Text = ROMAN_1274;
                            break;
                        case 1275:
                            label1.Text = ROMAN_1275;
                            break;
                        case 1276:
                            label1.Text = ROMAN_1276;
                            break;
                        case 1277:
                            label1.Text = ROMAN_1277;
                            break;
                        case 1278:
                            label1.Text = ROMAN_1278;
                            break;
                        case 1279:
                            label1.Text = ROMAN_1279;
                            break;
                        case 1280:
                            label1.Text = ROMAN_1280;
                            break;

                        case 1281:
                            label1.Text = ROMAN_1281;
                            break;
                        case 1282:
                            label1.Text = ROMAN_1282;
                            break;
                        case 1283:
                            label1.Text = ROMAN_1283;
                            break;
                        case 1284:
                            label1.Text = ROMAN_1284;
                            break;
                        case 1285:
                            label1.Text = ROMAN_1285;
                            break;
                        case 1286:
                            label1.Text = ROMAN_1286;
                            break;
                        case 1287:
                            label1.Text = ROMAN_1287;
                            break;
                        case 1288:
                            label1.Text = ROMAN_1288;
                            break;
                        case 1289:
                            label1.Text = ROMAN_1289;
                            break;
                        case 1290:
                            label1.Text = ROMAN_1290;
                            break;

                        case 1291:
                            label1.Text = ROMAN_1291;
                            break;
                        case 1292:
                            label1.Text = ROMAN_1292;
                            break;
                        case 1293:
                            label1.Text = ROMAN_1293;
                            break;
                        case 1294:
                            label1.Text = ROMAN_1294;
                            break;
                        case 1295:
                            label1.Text = ROMAN_1295;
                            break;
                        case 1296:
                            label1.Text = ROMAN_1296;
                            break;
                        case 1297:
                            label1.Text = ROMAN_1297;
                            break;
                        case 1298:
                            label1.Text = ROMAN_1298;
                            break;
                        case 1299:
                            label1.Text = ROMAN_1299;
                            break;
                        case 1300:
                            label1.Text = ROMAN_1300;
                            break;
                        case 1301:
                            label1.Text = ROMAN_1301;
                            break;
                        case 1302:
                            label1.Text = ROMAN_1302;
                            break;
                        case 1303:
                            label1.Text = ROMAN_1303;
                            break;
                        case 1304:
                            label1.Text = ROMAN_1304;
                            break;
                        case 1305:
                            label1.Text = ROMAN_1305;
                            break;
                        case 1306:
                            label1.Text = ROMAN_1306;
                            break;
                        case 1307:
                            label1.Text = ROMAN_1307;
                            break;
                        case 1308:
                            label1.Text = ROMAN_1308;
                            break;
                        case 1309:
                            label1.Text = ROMAN_1309;
                            break;
                        case 1310:
                            label1.Text = ROMAN_1310;
                            break;
                        //               default:
                        //                   label1.Text = "Kun årstallene 1 - 2030";
                        //                  break;
                        case 1311:
                            label1.Text = ROMAN_1311;
                            break;
                        case 1312:
                            label1.Text = ROMAN_1312;
                            break;
                        case 1313:
                            label1.Text = ROMAN_1313;
                            break;
                        case 1314:
                            label1.Text = ROMAN_1314;
                            break;
                        case 1315:
                            label1.Text = ROMAN_1315;
                            break;
                        case 1316:
                            label1.Text = ROMAN_1316;
                            break;
                        case 1317:
                            label1.Text = ROMAN_1317;
                            break;
                        case 1318:
                            label1.Text = ROMAN_1318;
                            break;
                        case 1319:
                            label1.Text = ROMAN_1319;
                            break;
                        case 1320:
                            label1.Text = ROMAN_1320;
                            break;
                        case 1321:
                            label1.Text = ROMAN_1321;
                            break;
                        case 1322:
                            label1.Text = ROMAN_1322;
                            break;
                        case 1323:
                            label1.Text = ROMAN_1323;
                            break;
                        case 1324:
                            label1.Text = ROMAN_1324;
                            break;
                        case 1325:
                            label1.Text = ROMAN_1325;
                            break;
                        case 1326:
                            label1.Text = ROMAN_1326;
                            break;
                        case 1327:
                            label1.Text = ROMAN_1327;
                            break;
                        case 1328:
                            label1.Text = ROMAN_1328;
                            break;
                        case 1329:
                            label1.Text = ROMAN_1329;
                            break;
                        case 1330:
                            label1.Text = ROMAN_1330;
                            break;

                        case 1331:
                            label1.Text = ROMAN_1331;
                            break;
                        case 1332:
                            label1.Text = ROMAN_1332;
                            break;
                        case 1333:
                            label1.Text = ROMAN_1333;
                            break;
                        case 1334:
                            label1.Text = ROMAN_1334;
                            break;
                        case 1335:
                            label1.Text = ROMAN_1335;
                            break;
                        case 1336:
                            label1.Text = ROMAN_1336;
                            break;
                        case 1337:
                            label1.Text = ROMAN_1337;
                            break;
                        case 1338:
                            label1.Text = ROMAN_1338;
                            break;
                        case 1339:
                            label1.Text = ROMAN_1339;
                            break;
                        case 1340:
                            label1.Text = ROMAN_1340;
                            break;

                        case 1341:
                            label1.Text = ROMAN_1341;
                            break;
                        case 1342:
                            label1.Text = ROMAN_1342;
                            break;
                        case 1343:
                            label1.Text = ROMAN_1343;
                            break;
                        case 1344:
                            label1.Text = ROMAN_1344;
                            break;
                        case 1345:
                            label1.Text = ROMAN_1345;
                            break;
                        case 1346:
                            label1.Text = ROMAN_1346;
                            break;
                        case 1347:
                            label1.Text = ROMAN_1347;
                            break;
                        case 1348:
                            label1.Text = ROMAN_1348;
                            break;
                        case 1349:
                            label1.Text = ROMAN_1349;
                            break;
                        case 1350:
                            label1.Text = ROMAN_1350;
                            break;

                        case 1351:
                            label1.Text = ROMAN_1351;
                            break;
                        case 1352:
                            label1.Text = ROMAN_1352;
                            break;
                        case 1353:
                            label1.Text = ROMAN_1353;
                            break;
                        case 1354:
                            label1.Text = ROMAN_1354;
                            break;
                        case 1355:
                            label1.Text = ROMAN_1355;
                            break;
                        case 1356:
                            label1.Text = ROMAN_1356;
                            break;
                        case 1357:
                            label1.Text = ROMAN_1357;
                            break;
                        case 1358:
                            label1.Text = ROMAN_1358;
                            break;
                        case 1359:
                            label1.Text = ROMAN_1359;
                            break;
                        case 1360:
                            label1.Text = ROMAN_1360;
                            break;
                        case 1361:
                            label1.Text = ROMAN_1361;
                            break;
                        case 1362:
                            label1.Text = ROMAN_1362;
                            break;
                        case 1363:
                            label1.Text = ROMAN_1363;
                            break;
                        case 1364:
                            label1.Text = ROMAN_1364;
                            break;
                        case 1365:
                            label1.Text = ROMAN_1365;
                            break;
                        case 1366:
                            label1.Text = ROMAN_1366;
                            break;
                        case 1367:
                            label1.Text = ROMAN_1367;
                            break;
                        case 1368:
                            label1.Text = ROMAN_1368;
                            break;
                        case 1369:
                            label1.Text = ROMAN_1369;
                            break;
                        case 1370:
                            label1.Text = ROMAN_1370;
                            break;

                        case 1371:
                            label1.Text = ROMAN_1371;
                            break;
                        case 1372:
                            label1.Text = ROMAN_1372;
                            break;
                        case 1373:
                            label1.Text = ROMAN_1373;
                            break;
                        case 1374:
                            label1.Text = ROMAN_1374;
                            break;
                        case 1375:
                            label1.Text = ROMAN_1375;
                            break;
                        case 1376:
                            label1.Text = ROMAN_1376;
                            break;
                        case 1377:
                            label1.Text = ROMAN_1377;
                            break;
                        case 1378:
                            label1.Text = ROMAN_1378;
                            break;
                        case 1379:
                            label1.Text = ROMAN_1379;
                            break;
                        case 1380:
                            label1.Text = ROMAN_1380;
                            break;

                        case 1381:
                            label1.Text = ROMAN_1381;
                            break;
                        case 1382:
                            label1.Text = ROMAN_1382;
                            break;
                        case 1383:
                            label1.Text = ROMAN_1383;
                            break;
                        case 1384:
                            label1.Text = ROMAN_1384;
                            break;
                        case 1385:
                            label1.Text = ROMAN_1385;
                            break;
                        case 1386:
                            label1.Text = ROMAN_1386;
                            break;
                        case 1387:
                            label1.Text = ROMAN_1387;
                            break;
                        case 1388:
                            label1.Text = ROMAN_1388;
                            break;
                        case 1389:
                            label1.Text = ROMAN_1389;
                            break;
                        case 1390:
                            label1.Text = ROMAN_1390;
                            break;

                        case 1391:
                            label1.Text = ROMAN_1391;
                            break;
                        case 1392:
                            label1.Text = ROMAN_1392;
                            break;
                        case 1393:
                            label1.Text = ROMAN_1393;
                            break;
                        case 1394:
                            label1.Text = ROMAN_1394;
                            break;
                        case 1395:
                            label1.Text = ROMAN_1395;
                            break;
                        case 1396:
                            label1.Text = ROMAN_1396;
                            break;
                        case 1397:
                            label1.Text = ROMAN_1397;
                            break;
                        case 1398:
                            label1.Text = ROMAN_1398;
                            break;
                        case 1399:
                            label1.Text = ROMAN_1399;
                            break;
                        case 1400:
                            label1.Text = ROMAN_1400;
                            break;

                        case 1401:
                            label1.Text = ROMAN_1401;
                            break;
                        case 1402:
                            label1.Text = ROMAN_1402;
                            break;
                        case 1403:
                            label1.Text = ROMAN_1403;
                            break;
                        case 1404:
                            label1.Text = ROMAN_1404;
                            break;
                        case 1405:
                            label1.Text = ROMAN_1405;
                            break;
                        case 1406:
                            label1.Text = ROMAN_1406;
                            break;
                        case 1407:
                            label1.Text = ROMAN_1407;
                            break;
                        case 1408:
                            label1.Text = ROMAN_1408;
                            break;
                        case 1409:
                            label1.Text = ROMAN_1409;
                            break;
                        case 1410:
                            label1.Text = ROMAN_1410;
                            break;
                        //               default:
                        //                   label1.Text = "Kun årstallene 1 - 2030";
                        //                  break;
                        case 1411:
                            label1.Text = ROMAN_1411;
                            break;
                        case 1412:
                            label1.Text = ROMAN_1412;
                            break;
                        case 1413:
                            label1.Text = ROMAN_1413;
                            break;
                        case 1414:
                            label1.Text = ROMAN_1414;
                            break;
                        case 1415:
                            label1.Text = ROMAN_1415;
                            break;
                        case 1416:
                            label1.Text = ROMAN_1416;
                            break;
                        case 1417:
                            label1.Text = ROMAN_1417;
                            break;
                        case 1418:
                            label1.Text = ROMAN_1418;
                            break;
                        case 1419:
                            label1.Text = ROMAN_1419;
                            break;
                        case 1420:
                            label1.Text = ROMAN_1420;
                            break;
                        case 1421:
                            label1.Text = ROMAN_1421;
                            break;
                        case 1422:
                            label1.Text = ROMAN_1422;
                            break;
                        case 1423:
                            label1.Text = ROMAN_1423;
                            break;
                        case 1424:
                            label1.Text = ROMAN_1424;
                            break;
                        case 1425:
                            label1.Text = ROMAN_1425;
                            break;
                        case 1426:
                            label1.Text = ROMAN_1426;
                            break;
                        case 1427:
                            label1.Text = ROMAN_1427;
                            break;
                        case 1428:
                            label1.Text = ROMAN_1428;
                            break;
                        case 1429:
                            label1.Text = ROMAN_1429;
                            break;
                        case 1430:
                            label1.Text = ROMAN_1430;
                            break;

                        case 1431:
                            label1.Text = ROMAN_1431;
                            break;
                        case 1432:
                            label1.Text = ROMAN_1432;
                            break;
                        case 1433:
                            label1.Text = ROMAN_1433;
                            break;
                        case 1434:
                            label1.Text = ROMAN_1434;
                            break;
                        case 1435:
                            label1.Text = ROMAN_1435;
                            break;
                        case 1436:
                            label1.Text = ROMAN_1436;
                            break;
                        case 1437:
                            label1.Text = ROMAN_1437;
                            break;
                        case 1438:
                            label1.Text = ROMAN_1438;
                            break;
                        case 1439:
                            label1.Text = ROMAN_1439;
                            break;
                        case 1440:
                            label1.Text = ROMAN_1440;
                            break;

                        case 1441:
                            label1.Text = ROMAN_1441;
                            break;
                        case 1442:
                            label1.Text = ROMAN_1442;
                            break;
                        case 1443:
                            label1.Text = ROMAN_1443;
                            break;
                        case 1444:
                            label1.Text = ROMAN_1444;
                            break;
                        case 1445:
                            label1.Text = ROMAN_1445;
                            break;
                        case 1446:
                            label1.Text = ROMAN_1446;
                            break;
                        case 1447:
                            label1.Text = ROMAN_1447;
                            break;
                        case 1448:
                            label1.Text = ROMAN_1448;
                            break;
                        case 1449:
                            label1.Text = ROMAN_1449;
                            break;
                        case 1450:
                            label1.Text = ROMAN_1450;
                            break;

                        case 1451:
                            label1.Text = ROMAN_1451;
                            break;
                        case 1452:
                            label1.Text = ROMAN_1452;
                            break;
                        case 1453:
                            label1.Text = ROMAN_1453;
                            break;
                        case 1454:
                            label1.Text = ROMAN_1454;
                            break;
                        case 1455:
                            label1.Text = ROMAN_1455;
                            break;
                        case 1456:
                            label1.Text = ROMAN_1456;
                            break;
                        case 1457:
                            label1.Text = ROMAN_1457;
                            break;
                        case 1458:
                            label1.Text = ROMAN_1458;
                            break;
                        case 1459:
                            label1.Text = ROMAN_1459;
                            break;
                        case 1460:
                            label1.Text = ROMAN_1460;
                            break;
                        case 1461:
                            label1.Text = ROMAN_1461;
                            break;
                        case 1462:
                            label1.Text = ROMAN_1462;
                            break;
                        case 1463:
                            label1.Text = ROMAN_1463;
                            break;
                        case 1464:
                            label1.Text = ROMAN_1464;
                            break;
                        case 1465:
                            label1.Text = ROMAN_1465;
                            break;
                        case 1466:
                            label1.Text = ROMAN_1466;
                            break;
                        case 1467:
                            label1.Text = ROMAN_1467;
                            break;
                        case 1468:
                            label1.Text = ROMAN_1468;
                            break;
                        case 1469:
                            label1.Text = ROMAN_1469;
                            break;
                        case 1470:
                            label1.Text = ROMAN_1470;
                            break;

                        case 1471:
                            label1.Text = ROMAN_1471;
                            break;
                        case 1472:
                            label1.Text = ROMAN_1472;
                            break;
                        case 1473:
                            label1.Text = ROMAN_1473;
                            break;
                        case 1474:
                            label1.Text = ROMAN_1474;
                            break;
                        case 1475:
                            label1.Text = ROMAN_1475;
                            break;
                        case 1476:
                            label1.Text = ROMAN_1476;
                            break;
                        case 1477:
                            label1.Text = ROMAN_1477;
                            break;
                        case 1478:
                            label1.Text = ROMAN_1478;
                            break;
                        case 1479:
                            label1.Text = ROMAN_1479;
                            break;
                        case 1480:
                            label1.Text = ROMAN_1480;
                            break;

                        case 1481:
                            label1.Text = ROMAN_1481;
                            break;
                        case 1482:
                            label1.Text = ROMAN_1482;
                            break;
                        case 1483:
                            label1.Text = ROMAN_1483;
                            break;
                        case 1484:
                            label1.Text = ROMAN_1484;
                            break;
                        case 1485:
                            label1.Text = ROMAN_1485;
                            break;
                        case 1486:
                            label1.Text = ROMAN_1486;
                            break;
                        case 1487:
                            label1.Text = ROMAN_1487;
                            break;
                        case 1488:
                            label1.Text = ROMAN_1488;
                            break;
                        case 1489:
                            label1.Text = ROMAN_1489;
                            break;
                        case 1490:
                            label1.Text = ROMAN_1490;
                            break;

                        case 1491:
                            label1.Text = ROMAN_1491;
                            break;
                        case 1492:
                            label1.Text = ROMAN_1492;
                            break;
                        case 1493:
                            label1.Text = ROMAN_1493;
                            break;
                        case 1494:
                            label1.Text = ROMAN_1494;
                            break;
                        case 1495:
                            label1.Text = ROMAN_1495;
                            break;
                        case 1496:
                            label1.Text = ROMAN_1496;
                            break;
                        case 1497:
                            label1.Text = ROMAN_1497;
                            break;
                        case 1498:
                            label1.Text = ROMAN_1498;
                            break;
                        case 1499:
                            label1.Text = ROMAN_1499;
                            break;
                        case 1500:
                            label1.Text = ROMAN_1500;
                            break;
                        case 1501:
                            label1.Text = ROMAN_1501;
                            break;
                        case 1502:
                            label1.Text = ROMAN_1502;
                            break;
                        case 1503:
                            label1.Text = ROMAN_1503;
                            break;
                        case 1504:
                            label1.Text = ROMAN_1504;
                            break;
                        case 1505:
                            label1.Text = ROMAN_1505;
                            break;
                        case 1506:
                            label1.Text = ROMAN_1506;
                            break;
                        case 1507:
                            label1.Text = ROMAN_1507;
                            break;
                        case 1508:
                            label1.Text = ROMAN_1508;
                            break;
                        case 1509:
                            label1.Text = ROMAN_1509;
                            break;
                        case 1510:
                            label1.Text = ROMAN_1510;
                            break;
                        //               default:
                        //                   label1.Text = "Kun årstallene 1 - 2030";
                        //                  break;
                        case 1511:
                            label1.Text = ROMAN_1511;
                            break;
                        case 1512:
                            label1.Text = ROMAN_1512;
                            break;
                        case 1513:
                            label1.Text = ROMAN_1513;
                            break;
                        case 1514:
                            label1.Text = ROMAN_1514;
                            break;
                        case 1515:
                            label1.Text = ROMAN_1515;
                            break;
                        case 1516:
                            label1.Text = ROMAN_1516;
                            break;
                        case 1517:
                            label1.Text = ROMAN_1517;
                            break;
                        case 1518:
                            label1.Text = ROMAN_1518;
                            break;
                        case 1519:
                            label1.Text = ROMAN_1519;
                            break;
                        case 1520:
                            label1.Text = ROMAN_1520;
                            break;
                        case 1521:
                            label1.Text = ROMAN_1521;
                            break;
                        case 1522:
                            label1.Text = ROMAN_1522;
                            break;
                        case 1523:
                            label1.Text = ROMAN_1523;
                            break;
                        case 1524:
                            label1.Text = ROMAN_1524;
                            break;
                        case 1525:
                            label1.Text = ROMAN_1525;
                            break;
                        case 1526:
                            label1.Text = ROMAN_1526;
                            break;
                        case 1527:
                            label1.Text = ROMAN_1527;
                            break;
                        case 1528:
                            label1.Text = ROMAN_1528;
                            break;
                        case 1529:
                            label1.Text = ROMAN_1529;
                            break;
                        case 1530:
                            label1.Text = ROMAN_1530;
                            break;

                        case 1531:
                            label1.Text = ROMAN_1531;
                            break;
                        case 1532:
                            label1.Text = ROMAN_1532;
                            break;
                        case 1533:
                            label1.Text = ROMAN_1533;
                            break;
                        case 1534:
                            label1.Text = ROMAN_1534;
                            break;
                        case 1535:
                            label1.Text = ROMAN_1535;
                            break;
                        case 1536:
                            label1.Text = ROMAN_1536;
                            break;
                        case 1537:
                            label1.Text = ROMAN_1537;
                            break;
                        case 1538:
                            label1.Text = ROMAN_1538;
                            break;
                        case 1539:
                            label1.Text = ROMAN_1539;
                            break;
                        case 1540:
                            label1.Text = ROMAN_1540;
                            break;

                        case 1541:
                            label1.Text = ROMAN_1541;
                            break;
                        case 1542:
                            label1.Text = ROMAN_1542;
                            break;
                        case 1543:
                            label1.Text = ROMAN_1543;
                            break;
                        case 1544:
                            label1.Text = ROMAN_1544;
                            break;
                        case 1545:
                            label1.Text = ROMAN_1545;
                            break;
                        case 1546:
                            label1.Text = ROMAN_1546;
                            break;
                        case 1547:
                            label1.Text = ROMAN_1547;
                            break;
                        case 1548:
                            label1.Text = ROMAN_1548;
                            break;
                        case 1549:
                            label1.Text = ROMAN_1549;
                            break;
                        case 1550:
                            label1.Text = ROMAN_1550;
                            break;

                        case 1551:
                            label1.Text = ROMAN_1551;
                            break;
                        case 1552:
                            label1.Text = ROMAN_1552;
                            break;
                        case 1553:
                            label1.Text = ROMAN_1553;
                            break;
                        case 1554:
                            label1.Text = ROMAN_1554;
                            break;
                        case 1555:
                            label1.Text = ROMAN_1555;
                            break;
                        case 1556:
                            label1.Text = ROMAN_1556;
                            break;
                        case 1557:
                            label1.Text = ROMAN_1557;
                            break;
                        case 1558:
                            label1.Text = ROMAN_1558;
                            break;
                        case 1559:
                            label1.Text = ROMAN_1559;
                            break;
                        case 1560:
                            label1.Text = ROMAN_1560;
                            break;
                        case 1561:
                            label1.Text = ROMAN_1561;
                            break;
                        case 1562:
                            label1.Text = ROMAN_1562;
                            break;
                        case 1563:
                            label1.Text = ROMAN_1563;
                            break;
                        case 1564:
                            label1.Text = ROMAN_1564;
                            break;
                        case 1565:
                            label1.Text = ROMAN_1565;
                            break;
                        case 1566:
                            label1.Text = ROMAN_1566;
                            break;
                        case 1567:
                            label1.Text = ROMAN_1567;
                            break;
                        case 1568:
                            label1.Text = ROMAN_1568;
                            break;
                        case 1569:
                            label1.Text = ROMAN_1569;
                            break;
                        case 1570:
                            label1.Text = ROMAN_1570;
                            break;

                        case 1571:
                            label1.Text = ROMAN_1571;
                            break;
                        case 1572:
                            label1.Text = ROMAN_1572;
                            break;
                        case 1573:
                            label1.Text = ROMAN_1573;
                            break;
                        case 1574:
                            label1.Text = ROMAN_1574;
                            break;
                        case 1575:
                            label1.Text = ROMAN_1575;
                            break;
                        case 1576:
                            label1.Text = ROMAN_1576;
                            break;
                        case 1577:
                            label1.Text = ROMAN_1577;
                            break;
                        case 1578:
                            label1.Text = ROMAN_1578;
                            break;
                        case 1579:
                            label1.Text = ROMAN_1579;
                            break;
                        case 1580:
                            label1.Text = ROMAN_1580;
                            break;

                        case 1581:
                            label1.Text = ROMAN_1581;
                            break;
                        case 1582:
                            label1.Text = ROMAN_1582;
                            break;
                        case 1583:
                            label1.Text = ROMAN_1583;
                            break;
                        case 1584:
                            label1.Text = ROMAN_1584;
                            break;
                        case 1585:
                            label1.Text = ROMAN_1585;
                            break;
                        case 1586:
                            label1.Text = ROMAN_1586;
                            break;
                        case 1587:
                            label1.Text = ROMAN_1587;
                            break;
                        case 1588:
                            label1.Text = ROMAN_1588;
                            break;
                        case 1589:
                            label1.Text = ROMAN_1589;
                            break;
                        case 1590:
                            label1.Text = ROMAN_1590;
                            break;

                        case 1591:
                            label1.Text = ROMAN_1591;
                            break;
                        case 1592:
                            label1.Text = ROMAN_1592;
                            break;
                        case 1593:
                            label1.Text = ROMAN_1593;
                            break;
                        case 1594:
                            label1.Text = ROMAN_1594;
                            break;
                        case 1595:
                            label1.Text = ROMAN_1595;
                            break;
                        case 1596:
                            label1.Text = ROMAN_1596;
                            break;
                        case 1597:
                            label1.Text = ROMAN_1597;
                            break;
                        case 1598:
                            label1.Text = ROMAN_1598;
                            break;
                        case 1599:
                            label1.Text = ROMAN_1599;
                            break;
                        case 1600:
                            label1.Text = ROMAN_1600;
                            break;

                        case 1601:
                            label1.Text = ROMAN_1601;
                            break;
                        case 1602:
                            label1.Text = ROMAN_1602;
                            break;
                        case 1603:
                            label1.Text = ROMAN_1603;
                            break;
                        case 1604:
                            label1.Text = ROMAN_1604;
                            break;
                        case 1605:
                            label1.Text = ROMAN_1605;
                            break;
                        case 1606:
                            label1.Text = ROMAN_1606;
                            break;
                        case 1607:
                            label1.Text = ROMAN_1607;
                            break;
                        case 1608:
                            label1.Text = ROMAN_1608;
                            break;
                        case 1609:
                            label1.Text = ROMAN_1609;
                            break;
                        case 1610:
                            label1.Text = ROMAN_1610;
                            break;
                        //               default:
                        //                   label1.Text = "Kun årstallene 1 - 2030";
                        //                  break;
                        case 1611:
                            label1.Text = ROMAN_1611;
                            break;
                        case 1612:
                            label1.Text = ROMAN_1612;
                            break;
                        case 1613:
                            label1.Text = ROMAN_1613;
                            break;
                        case 1614:
                            label1.Text = ROMAN_1614;
                            break;
                        case 1615:
                            label1.Text = ROMAN_1615;
                            break;
                        case 1616:
                            label1.Text = ROMAN_1616;
                            break;
                        case 1617:
                            label1.Text = ROMAN_1617;
                            break;
                        case 1618:
                            label1.Text = ROMAN_1618;
                            break;
                        case 1619:
                            label1.Text = ROMAN_1619;
                            break;
                        case 1620:
                            label1.Text = ROMAN_1620;
                            break;
                        case 1621:
                            label1.Text = ROMAN_1621;
                            break;
                        case 1622:
                            label1.Text = ROMAN_1622;
                            break;
                        case 1623:
                            label1.Text = ROMAN_1623;
                            break;
                        case 1624:
                            label1.Text = ROMAN_1624;
                            break;
                        case 1625:
                            label1.Text = ROMAN_1625;
                            break;
                        case 1626:
                            label1.Text = ROMAN_1626;
                            break;
                        case 1627:
                            label1.Text = ROMAN_1627;
                            break;
                        case 1628:
                            label1.Text = ROMAN_1628;
                            break;
                        case 1629:
                            label1.Text = ROMAN_1629;
                            break;
                        case 1630:
                            label1.Text = ROMAN_1630;
                            break;

                        case 1631:
                            label1.Text = ROMAN_1631;
                            break;
                        case 1632:
                            label1.Text = ROMAN_1632;
                            break;
                        case 1633:
                            label1.Text = ROMAN_1633;
                            break;
                        case 1634:
                            label1.Text = ROMAN_1634;
                            break;
                        case 1635:
                            label1.Text = ROMAN_1635;
                            break;
                        case 1636:
                            label1.Text = ROMAN_1636;
                            break;
                        case 1637:
                            label1.Text = ROMAN_1637;
                            break;
                        case 1638:
                            label1.Text = ROMAN_1638;
                            break;
                        case 1639:
                            label1.Text = ROMAN_1639;
                            break;
                        case 1640:
                            label1.Text = ROMAN_1640;
                            break;

                        case 1641:
                            label1.Text = ROMAN_1641;
                            break;
                        case 1642:
                            label1.Text = ROMAN_1642;
                            break;
                        case 1643:
                            label1.Text = ROMAN_1643;
                            break;
                        case 1644:
                            label1.Text = ROMAN_1644;
                            break;
                        case 1645:
                            label1.Text = ROMAN_1645;
                            break;
                        case 1646:
                            label1.Text = ROMAN_1646;
                            break;
                        case 1647:
                            label1.Text = ROMAN_1647;
                            break;
                        case 1648:
                            label1.Text = ROMAN_1648;
                            break;
                        case 1649:
                            label1.Text = ROMAN_1649;
                            break;
                        case 1650:
                            label1.Text = ROMAN_1650;
                            break;

                        case 1651:
                            label1.Text = ROMAN_1651;
                            break;
                        case 1652:
                            label1.Text = ROMAN_1652;
                            break;
                        case 1653:
                            label1.Text = ROMAN_1653;
                            break;
                        case 1654:
                            label1.Text = ROMAN_1654;
                            break;
                        case 1655:
                            label1.Text = ROMAN_1655;
                            break;
                        case 1656:
                            label1.Text = ROMAN_1656;
                            break;
                        case 1657:
                            label1.Text = ROMAN_1657;
                            break;
                        case 1658:
                            label1.Text = ROMAN_1658;
                            break;
                        case 1659:
                            label1.Text = ROMAN_1659;
                            break;
                        case 1660:
                            label1.Text = ROMAN_1660;
                            break;
                        case 1661:
                            label1.Text = ROMAN_1661;
                            break;
                        case 1662:
                            label1.Text = ROMAN_1662;
                            break;
                        case 1663:
                            label1.Text = ROMAN_1663;
                            break;
                        case 1664:
                            label1.Text = ROMAN_1664;
                            break;
                        case 1665:
                            label1.Text = ROMAN_1665;
                            break;
                        case 1666:
                            label1.Text = ROMAN_1666;
                            break;
                        case 1667:
                            label1.Text = ROMAN_1667;
                            break;
                        case 1668:
                            label1.Text = ROMAN_1668;
                            break;
                        case 1669:
                            label1.Text = ROMAN_1669;
                            break;
                        case 1670:
                            label1.Text = ROMAN_1670;
                            break;

                        case 1671:
                            label1.Text = ROMAN_1671;
                            break;
                        case 1672:
                            label1.Text = ROMAN_1672;
                            break;
                        case 1673:
                            label1.Text = ROMAN_1673;
                            break;
                        case 1674:
                            label1.Text = ROMAN_1674;
                            break;
                        case 1675:
                            label1.Text = ROMAN_1675;
                            break;
                        case 1676:
                            label1.Text = ROMAN_1676;
                            break;
                        case 1677:
                            label1.Text = ROMAN_1677;
                            break;
                        case 1678:
                            label1.Text = ROMAN_1678;
                            break;
                        case 1679:
                            label1.Text = ROMAN_1679;
                            break;
                        case 1680:
                            label1.Text = ROMAN_1680;
                            break;

                        case 1681:
                            label1.Text = ROMAN_1681;
                            break;
                        case 1682:
                            label1.Text = ROMAN_1682;
                            break;
                        case 1683:
                            label1.Text = ROMAN_1683;
                            break;
                        case 1684:
                            label1.Text = ROMAN_1684;
                            break;
                        case 1685:
                            label1.Text = ROMAN_1685;
                            break;
                        case 1686:
                            label1.Text = ROMAN_1686;
                            break;
                        case 1687:
                            label1.Text = ROMAN_1687;
                            break;
                        case 1688:
                            label1.Text = ROMAN_1688;
                            break;
                        case 1689:
                            label1.Text = ROMAN_1689;
                            break;
                        case 1690:
                            label1.Text = ROMAN_1690;
                            break;

                        case 1691:
                            label1.Text = ROMAN_1691;
                            break;
                        case 1692:
                            label1.Text = ROMAN_1692;
                            break;
                        case 1693:
                            label1.Text = ROMAN_1693;
                            break;
                        case 1694:
                            label1.Text = ROMAN_1694;
                            break;
                        case 1695:
                            label1.Text = ROMAN_1695;
                            break;
                        case 1696:
                            label1.Text = ROMAN_1696;
                            break;
                        case 1697:
                            label1.Text = ROMAN_1697;
                            break;
                        case 1698:
                            label1.Text = ROMAN_1698;
                            break;
                        case 1699:
                            label1.Text = ROMAN_1699;
                            break;
                        case 1700:
                            label1.Text = ROMAN_1700;
                            break;
                        case 1701:
                            label1.Text = ROMAN_1701;
                            break;
                        case 1702:
                            label1.Text = ROMAN_1702;
                            break;
                        case 1703:
                            label1.Text = ROMAN_1703;
                            break;
                        case 1704:
                            label1.Text = ROMAN_1704;
                            break;
                        case 1705:
                            label1.Text = ROMAN_1705;
                            break;
                        case 1706:
                            label1.Text = ROMAN_1706;
                            break;
                        case 1707:
                            label1.Text = ROMAN_1707;
                            break;
                        case 1708:
                            label1.Text = ROMAN_1708;
                            break;
                        case 1709:
                            label1.Text = ROMAN_1709;
                            break;
                        case 1710:
                            label1.Text = ROMAN_1710;
                            break;
                        //               default:
                        //                   label1.Text = "Kun årstallene 1 - 2030";
                        //                  break;
                        case 1711:
                            label1.Text = ROMAN_1711;
                            break;
                        case 1712:
                            label1.Text = ROMAN_1712;
                            break;
                        case 1713:
                            label1.Text = ROMAN_1713;
                            break;
                        case 1714:
                            label1.Text = ROMAN_1714;
                            break;
                        case 1715:
                            label1.Text = ROMAN_1715;
                            break;
                        case 1716:
                            label1.Text = ROMAN_1716;
                            break;
                        case 1717:
                            label1.Text = ROMAN_1717;
                            break;
                        case 1718:
                            label1.Text = ROMAN_1718;
                            break;
                        case 1719:
                            label1.Text = ROMAN_1719;
                            break;
                        case 1720:
                            label1.Text = ROMAN_1720;
                            break;
                        case 1721:
                            label1.Text = ROMAN_1721;
                            break;
                        case 1722:
                            label1.Text = ROMAN_1722;
                            break;
                        case 1723:
                            label1.Text = ROMAN_1723;
                            break;
                        case 1724:
                            label1.Text = ROMAN_1724;
                            break;
                        case 1725:
                            label1.Text = ROMAN_1725;
                            break;
                        case 1726:
                            label1.Text = ROMAN_1726;
                            break;
                        case 1727:
                            label1.Text = ROMAN_1727;
                            break;
                        case 1728:
                            label1.Text = ROMAN_1728;
                            break;
                        case 1729:
                            label1.Text = ROMAN_1729;
                            break;
                        case 1730:
                            label1.Text = ROMAN_1730;
                            break;

                        case 1731:
                            label1.Text = ROMAN_1731;
                            break;
                        case 1732:
                            label1.Text = ROMAN_1732;
                            break;
                        case 1733:
                            label1.Text = ROMAN_1733;
                            break;
                        case 1734:
                            label1.Text = ROMAN_1734;
                            break;
                        case 1735:
                            label1.Text = ROMAN_1735;
                            break;
                        case 1736:
                            label1.Text = ROMAN_1736;
                            break;
                        case 1737:
                            label1.Text = ROMAN_1737;
                            break;
                        case 1738:
                            label1.Text = ROMAN_1738;
                            break;
                        case 1739:
                            label1.Text = ROMAN_1739;
                            break;
                        case 1740:
                            label1.Text = ROMAN_1740;
                            break;

                        case 1741:
                            label1.Text = ROMAN_1741;
                            break;
                        case 1742:
                            label1.Text = ROMAN_1742;
                            break;
                        case 1743:
                            label1.Text = ROMAN_1743;
                            break;
                        case 1744:
                            label1.Text = ROMAN_1744;
                            break;
                        case 1745:
                            label1.Text = ROMAN_1745;
                            break;
                        case 1746:
                            label1.Text = ROMAN_1746;
                            break;
                        case 1747:
                            label1.Text = ROMAN_1747;
                            break;
                        case 1748:
                            label1.Text = ROMAN_1748;
                            break;
                        case 1749:
                            label1.Text = ROMAN_1749;
                            break;
                        case 1750:
                            label1.Text = ROMAN_1750;
                            break;

                        case 1751:
                            label1.Text = ROMAN_1751;
                            break;
                        case 1752:
                            label1.Text = ROMAN_1752;
                            break;
                        case 1753:
                            label1.Text = ROMAN_1753;
                            break;
                        case 1754:
                            label1.Text = ROMAN_1754;
                            break;
                        case 1755:
                            label1.Text = ROMAN_1755;
                            break;
                        case 1756:
                            label1.Text = ROMAN_1756;
                            break;
                        case 1757:
                            label1.Text = ROMAN_1757;
                            break;
                        case 1758:
                            label1.Text = ROMAN_1758;
                            break;
                        case 1759:
                            label1.Text = ROMAN_1759;
                            break;
                        case 1760:
                            label1.Text = ROMAN_1760;
                            break;
                        case 1761:
                            label1.Text = ROMAN_1761;
                            break;
                        case 1762:
                            label1.Text = ROMAN_1762;
                            break;
                        case 1763:
                            label1.Text = ROMAN_1763;
                            break;
                        case 1764:
                            label1.Text = ROMAN_1764;
                            break;
                        case 1765:
                            label1.Text = ROMAN_1765;
                            break;
                        case 1766:
                            label1.Text = ROMAN_1766;
                            break;
                        case 1767:
                            label1.Text = ROMAN_1767;
                            break;
                        case 1768:
                            label1.Text = ROMAN_1768;
                            break;
                        case 1769:
                            label1.Text = ROMAN_1769;
                            break;
                        case 1770:
                            label1.Text = ROMAN_1770;
                            break;

                        case 1771:
                            label1.Text = ROMAN_1771;
                            break;
                        case 1772:
                            label1.Text = ROMAN_1772;
                            break;
                        case 1773:
                            label1.Text = ROMAN_1773;
                            break;
                        case 1774:
                            label1.Text = ROMAN_1774;
                            break;
                        case 1775:
                            label1.Text = ROMAN_1775;
                            break;
                        case 1776:
                            label1.Text = ROMAN_1776;
                            break;
                        case 1777:
                            label1.Text = ROMAN_1777;
                            break;
                        case 1778:
                            label1.Text = ROMAN_1778;
                            break;
                        case 1779:
                            label1.Text = ROMAN_1779;
                            break;
                        case 1780:
                            label1.Text = ROMAN_1780;
                            break;

                        case 1781:
                            label1.Text = ROMAN_1781;
                            break;
                        case 1782:
                            label1.Text = ROMAN_1782;
                            break;
                        case 1783:
                            label1.Text = ROMAN_1783;
                            break;
                        case 1784:
                            label1.Text = ROMAN_1784;
                            break;
                        case 1785:
                            label1.Text = ROMAN_1785;
                            break;
                        case 1786:
                            label1.Text = ROMAN_1786;
                            break;
                        case 1787:
                            label1.Text = ROMAN_1787;
                            break;
                        case 1788:
                            label1.Text = ROMAN_1788;
                            break;
                        case 1789:
                            label1.Text = ROMAN_1789;
                            break;
                        case 1790:
                            label1.Text = ROMAN_1790;
                            break;

                        case 1791:
                            label1.Text = ROMAN_1791;
                            break;
                        case 1792:
                            label1.Text = ROMAN_1792;
                            break;
                        case 1793:
                            label1.Text = ROMAN_1793;
                            break;
                        case 1794:
                            label1.Text = ROMAN_1794;
                            break;
                        case 1795:
                            label1.Text = ROMAN_1795;
                            break;
                        case 1796:
                            label1.Text = ROMAN_1796;
                            break;
                        case 1797:
                            label1.Text = ROMAN_1797;
                            break;
                        case 1798:
                            label1.Text = ROMAN_1798;
                            break;
                        case 1799:
                            label1.Text = ROMAN_1799;
                            break;
                        case 1800:
                            label1.Text = ROMAN_1800;
                            break;
                        case 1801:
                            label1.Text = ROMAN_1801;
                            break;
                        case 1802:
                            label1.Text = ROMAN_1802;
                            break;
                        case 1803:
                            label1.Text = ROMAN_1803;
                            break;
                        case 1804:
                            label1.Text = ROMAN_1804;
                            break;
                        case 1805:
                            label1.Text = ROMAN_1805;
                            break;
                        case 1806:
                            label1.Text = ROMAN_1806;
                            break;
                        case 1807:
                            label1.Text = ROMAN_1807;
                            break;
                        case 1808:
                            label1.Text = ROMAN_1808;
                            break;
                        case 1809:
                            label1.Text = ROMAN_1809;
                            break;
                        case 1810:
                            label1.Text = ROMAN_1810;
                            break;
                        //               default:
                        //                   label1.Text = "Kun årstallene 1 - 2030";
                        //                  break;
                        case 1811:
                            label1.Text = ROMAN_1811;
                            break;
                        case 1812:
                            label1.Text = ROMAN_1812;
                            break;
                        case 1813:
                            label1.Text = ROMAN_1813;
                            break;
                        case 1814:
                            label1.Text = ROMAN_1814;
                            break;
                        case 1815:
                            label1.Text = ROMAN_1815;
                            break;
                        case 1816:
                            label1.Text = ROMAN_1816;
                            break;
                        case 1817:
                            label1.Text = ROMAN_1817;
                            break;
                        case 1818:
                            label1.Text = ROMAN_1818;
                            break;
                        case 1819:
                            label1.Text = ROMAN_1819;
                            break;
                        case 1820:
                            label1.Text = ROMAN_1820;
                            break;
                        case 1821:
                            label1.Text = ROMAN_1821;
                            break;
                        case 1822:
                            label1.Text = ROMAN_1822;
                            break;
                        case 1823:
                            label1.Text = ROMAN_1823;
                            break;
                        case 1824:
                            label1.Text = ROMAN_1824;
                            break;
                        case 1825:
                            label1.Text = ROMAN_1825;
                            break;
                        case 1826:
                            label1.Text = ROMAN_1826;
                            break;
                        case 1827:
                            label1.Text = ROMAN_1827;
                            break;
                        case 1828:
                            label1.Text = ROMAN_1828;
                            break;
                        case 1829:
                            label1.Text = ROMAN_1829;
                            break;
                        case 1830:
                            label1.Text = ROMAN_1830;
                            break;

                        case 1831:
                            label1.Text = ROMAN_1831;
                            break;
                        case 1832:
                            label1.Text = ROMAN_1832;
                            break;
                        case 1833:
                            label1.Text = ROMAN_1833;
                            break;
                        case 1834:
                            label1.Text = ROMAN_1834;
                            break;
                        case 1835:
                            label1.Text = ROMAN_1835;
                            break;
                        case 1836:
                            label1.Text = ROMAN_1836;
                            break;
                        case 1837:
                            label1.Text = ROMAN_1837;
                            break;
                        case 1838:
                            label1.Text = ROMAN_1838;
                            break;
                        case 1839:
                            label1.Text = ROMAN_1839;
                            break;
                        case 1840:
                            label1.Text = ROMAN_1840;
                            break;

                        case 1841:
                            label1.Text = ROMAN_1841;
                            break;
                        case 1842:
                            label1.Text = ROMAN_1842;
                            break;
                        case 1843:
                            label1.Text = ROMAN_1843;
                            break;
                        case 1844:
                            label1.Text = ROMAN_1844;
                            break;
                        case 1845:
                            label1.Text = ROMAN_1845;
                            break;
                        case 1846:
                            label1.Text = ROMAN_1846;
                            break;
                        case 1847:
                            label1.Text = ROMAN_1847;
                            break;
                        case 1848:
                            label1.Text = ROMAN_1848;
                            break;
                        case 1849:
                            label1.Text = ROMAN_1849;
                            break;
                        case 1850:
                            label1.Text = ROMAN_1850;
                            break;

                        case 1851:
                            label1.Text = ROMAN_1851;
                            break;
                        case 1852:
                            label1.Text = ROMAN_1852;
                            break;
                        case 1853:
                            label1.Text = ROMAN_1853;
                            break;
                        case 1854:
                            label1.Text = ROMAN_1854;
                            break;
                        case 1855:
                            label1.Text = ROMAN_1855;
                            break;
                        case 1856:
                            label1.Text = ROMAN_1856;
                            break;
                        case 1857:
                            label1.Text = ROMAN_1857;
                            break;
                        case 1858:
                            label1.Text = ROMAN_1858;
                            break;
                        case 1859:
                            label1.Text = ROMAN_1859;
                            break;
                        case 1860:
                            label1.Text = ROMAN_1860;
                            break;
                        case 1861:
                            label1.Text = ROMAN_1861;
                            break;
                        case 1862:
                            label1.Text = ROMAN_1862;
                            break;
                        case 1863:
                            label1.Text = ROMAN_1863;
                            break;
                        case 1864:
                            label1.Text = ROMAN_1864;
                            break;
                        case 1865:
                            label1.Text = ROMAN_1865;
                            break;
                        case 1866:
                            label1.Text = ROMAN_1866;
                            break;
                        case 1867:
                            label1.Text = ROMAN_1867;
                            break;
                        case 1868:
                            label1.Text = ROMAN_1868;
                            break;
                        case 1869:
                            label1.Text = ROMAN_1869;
                            break;
                        case 1870:
                            label1.Text = ROMAN_1870;
                            break;

                        case 1871:
                            label1.Text = ROMAN_1871;
                            break;
                        case 1872:
                            label1.Text = ROMAN_1872;
                            break;
                        case 1873:
                            label1.Text = ROMAN_1873;
                            break;
                        case 1874:
                            label1.Text = ROMAN_1874;
                            break;
                        case 1875:
                            label1.Text = ROMAN_1875;
                            break;
                        case 1876:
                            label1.Text = ROMAN_1876;
                            break;
                        case 1877:
                            label1.Text = ROMAN_1877;
                            break;
                        case 1878:
                            label1.Text = ROMAN_1878;
                            break;
                        case 1879:
                            label1.Text = ROMAN_1879;
                            break;
                        case 1880:
                            label1.Text = ROMAN_1880;
                            break;

                        case 1881:
                            label1.Text = ROMAN_1881;
                            break;
                        case 1882:
                            label1.Text = ROMAN_1882;
                            break;
                        case 1883:
                            label1.Text = ROMAN_1883;
                            break;
                        case 1884:
                            label1.Text = ROMAN_1884;
                            break;
                        case 1885:
                            label1.Text = ROMAN_1885;
                            break;
                        case 1886:
                            label1.Text = ROMAN_1886;
                            break;
                        case 1887:
                            label1.Text = ROMAN_1887;
                            break;
                        case 1888:
                            label1.Text = ROMAN_1888;
                            break;
                        case 1889:
                            label1.Text = ROMAN_1889;
                            break;
                        case 1890:
                            label1.Text = ROMAN_1890;
                            break;

                        case 1891:
                            label1.Text = ROMAN_1891;
                            break;
                        case 1892:
                            label1.Text = ROMAN_1892;
                            break;
                        case 1893:
                            label1.Text = ROMAN_1893;
                            break;
                        case 1894:
                            label1.Text = ROMAN_1894;
                            break;
                        case 1895:
                            label1.Text = ROMAN_1895;
                            break;
                        case 1896:
                            label1.Text = ROMAN_1896;
                            break;
                        case 1897:
                            label1.Text = ROMAN_1897;
                            break;
                        case 1898:
                            label1.Text = ROMAN_1898;
                            break;
                        case 1899:
                            label1.Text = ROMAN_1899;
                            break;
                        case 1900:
                            label1.Text = ROMAN_1900;
                            break;

                        case 1901:
                            label1.Text = ROMAN_1901;
                            break;
                        case 1902:
                            label1.Text = ROMAN_1902;
                            break;
                        case 1903:
                            label1.Text = ROMAN_1903;
                            break;
                        case 1904:
                            label1.Text = ROMAN_1904;
                            break;
                        case 1905:
                            label1.Text = ROMAN_1905;
                            break;
                        case 1906:
                            label1.Text = ROMAN_1906;
                            break;
                        case 1907:
                            label1.Text = ROMAN_1907;
                            break;
                        case 1908:
                            label1.Text = ROMAN_1908;
                            break;
                        case 1909:
                            label1.Text = ROMAN_1909;
                            break;
                        case 1910:
                            label1.Text = ROMAN_1910;
                            break;
                        //               default:
                        //                   label1.Text = "Kun årstallene 1 - 2030";
                        //                  break;
                        case 1911:
                            label1.Text = ROMAN_1911;
                            break;
                        case 1912:
                            label1.Text = ROMAN_1912;
                            break;
                        case 1913:
                            label1.Text = ROMAN_1913;
                            break;
                        case 1914:
                            label1.Text = ROMAN_1914;
                            break;
                        case 1915:
                            label1.Text = ROMAN_1915;
                            break;
                        case 1916:
                            label1.Text = ROMAN_1916;
                            break;
                        case 1917:
                            label1.Text = ROMAN_1917;
                            break;
                        case 1918:
                            label1.Text = ROMAN_1918;
                            break;
                        case 1919:
                            label1.Text = ROMAN_1919;
                            break;
                        case 1920:
                            label1.Text = ROMAN_1920;
                            break;
                        case 1921:
                            label1.Text = ROMAN_1921;
                            break;
                        case 1922:
                            label1.Text = ROMAN_1922;
                            break;
                        case 1923:
                            label1.Text = ROMAN_1923;
                            break;
                        case 1924:
                            label1.Text = ROMAN_1924;
                            break;
                        case 1925:
                            label1.Text = ROMAN_1925;
                            break;
                        case 1926:
                            label1.Text = ROMAN_1926;
                            break;
                        case 1927:
                            label1.Text = ROMAN_1927;
                            break;
                        case 1928:
                            label1.Text = ROMAN_1928;
                            break;
                        case 1929:
                            label1.Text = ROMAN_1929;
                            break;
                        case 1930:
                            label1.Text = ROMAN_1930;
                            break;

                        case 1931:
                            label1.Text = ROMAN_1931;
                            break;
                        case 1932:
                            label1.Text = ROMAN_1932;
                            break;
                        case 1933:
                            label1.Text = ROMAN_1933;
                            break;
                        case 1934:
                            label1.Text = ROMAN_1934;
                            break;
                        case 1935:
                            label1.Text = ROMAN_1935;
                            break;
                        case 1936:
                            label1.Text = ROMAN_1936;
                            break;
                        case 1937:
                            label1.Text = ROMAN_1937;
                            break;
                        case 1938:
                            label1.Text = ROMAN_1938;
                            break;
                        case 1939:
                            label1.Text = ROMAN_1939;
                            break;
                        case 1940:
                            label1.Text = ROMAN_1940;
                            break;

                        case 1941:
                            label1.Text = ROMAN_1941;
                            break;
                        case 1942:
                            label1.Text = ROMAN_1942;
                            break;
                        case 1943:
                            label1.Text = ROMAN_1943;
                            break;
                        case 1944:
                            label1.Text = ROMAN_1944;
                            break;
                        case 1945:
                            label1.Text = ROMAN_1945;
                            break;
                        case 1946:
                            label1.Text = ROMAN_1946;
                            break;
                        case 1947:
                            label1.Text = ROMAN_1947;
                            break;
                        case 1948:
                            label1.Text = ROMAN_1948;
                            break;
                        case 1949:
                            label1.Text = ROMAN_1949;
                            break;
                        case 1950:
                            label1.Text = ROMAN_1950;
                            break;

                        case 1951:
                            label1.Text = ROMAN_1951;
                            break;
                        case 1952:
                            label1.Text = ROMAN_1952;
                            break;
                        case 1953:
                            label1.Text = ROMAN_1953;
                            break;
                        case 1954:
                            label1.Text = ROMAN_1954;
                            break;
                        case 1955:
                            label1.Text = ROMAN_1955;
                            break;
                        case 1956:
                            label1.Text = ROMAN_1956;
                            break;
                        case 1957:
                            label1.Text = ROMAN_1957;
                            break;
                        case 1958:
                            label1.Text = ROMAN_1958;
                            break;
                        case 1959:
                            label1.Text = ROMAN_1959;
                            break;
                        case 1960:
                            label1.Text = ROMAN_1960;
                            break;
                        case 1961:
                            label1.Text = ROMAN_1961;
                            break;
                        case 1962:
                            label1.Text = ROMAN_1962;
                            break;
                        case 1963:
                            label1.Text = ROMAN_1963;
                            break;
                        case 1964:
                            label1.Text = ROMAN_1964;
                            break;
                        case 1965:
                            label1.Text = ROMAN_1965;
                            break;
                        case 1966:
                            label1.Text = ROMAN_1966;
                            break;
                        case 1967:
                            label1.Text = ROMAN_1967;
                            break;
                        case 1968:
                            label1.Text = ROMAN_1968;
                            break;
                        case 1969:
                            label1.Text = ROMAN_1969;
                            break;
                        case 1970:
                            label1.Text = ROMAN_1970;
                            break;

                        case 1971:
                            label1.Text = ROMAN_1971;
                            break;
                        case 1972:
                            label1.Text = ROMAN_1972;
                            break;
                        case 1973:
                            label1.Text = ROMAN_1973;
                            break;
                        case 1974:
                            label1.Text = ROMAN_1974;
                            break;
                        case 1975:
                            label1.Text = ROMAN_1975;
                            break;
                        case 1976:
                            label1.Text = ROMAN_1976;
                            break;
                        case 1977:
                            label1.Text = ROMAN_1977;
                            break;
                        case 1978:
                            label1.Text = ROMAN_1978;
                            break;
                        case 1979:
                            label1.Text = ROMAN_1979;
                            break;
                        case 1980:
                            label1.Text = ROMAN_1980;
                            break;

                        case 1981:
                            label1.Text = ROMAN_1981;
                            break;
                        case 1982:
                            label1.Text = ROMAN_1982;
                            break;
                        case 1983:
                            label1.Text = ROMAN_1983;
                            break;
                        case 1984:
                            label1.Text = ROMAN_1984;
                            break;
                        case 1985:
                            label1.Text = ROMAN_1985;
                            break;
                        case 1986:
                            label1.Text = ROMAN_1986;
                            break;
                        case 1987:
                            label1.Text = ROMAN_1987;
                            break;
                        case 1988:
                            label1.Text = ROMAN_1988;
                            break;
                        case 1989:
                            label1.Text = ROMAN_1989;
                            break;
                        case 1990:
                            label1.Text = ROMAN_1990;
                            break;

                        case 1991:
                            label1.Text = ROMAN_1991;
                            break;
                        case 1992:
                            label1.Text = ROMAN_1992;
                            break;
                        case 1993:
                            label1.Text = ROMAN_1993;
                            break;
                        case 1994:
                            label1.Text = ROMAN_1994;
                            break;
                        case 1995:
                            label1.Text = ROMAN_1995;
                            break;
                        case 1996:
                            label1.Text = ROMAN_1996;
                            break;
                        case 1997:
                            label1.Text = ROMAN_1997;
                            break;
                        case 1998:
                            label1.Text = ROMAN_1998;
                            break;
                        case 1999:
                            label1.Text = ROMAN_1999;
                            break;
                        case 2000:
                            label1.Text = ROMAN_2000;
                            break;
                        case 2001:
                            label1.Text = ROMAN_2001;
                            break;
                        case 2002:
                            label1.Text = ROMAN_2002;
                            break;
                        case 2003:
                            label1.Text = ROMAN_2003;
                            break;
                        case 2004:
                            label1.Text = ROMAN_2004;
                            break;
                        case 2005:
                            label1.Text = ROMAN_2005;
                            break;
                        case 2006:
                            label1.Text = ROMAN_2006;
                            break;
                        case 2007:
                            label1.Text = ROMAN_2007;
                            break;
                        case 2008:
                            label1.Text = ROMAN_2008;
                            break;
                        case 2009:
                            label1.Text = ROMAN_2009;
                            break;
                        case 2010:
                            label1.Text = ROMAN_2010;
                            break;
                        //               default:
                        //                   label1.Text = "Kun årstallene 1 - 2030";
                        //                  break;
                        case 2011:
                            label1.Text = ROMAN_2011;
                            break;
                        case 2012:
                            label1.Text = ROMAN_2012;
                            break;
                        case 2013:
                            label1.Text = ROMAN_2013;
                            break;
                        case 2014:
                            label1.Text = ROMAN_2014;
                            break;
                        case 2015:
                            label1.Text = ROMAN_2015;
                            break;
                        case 2016:
                            label1.Text = ROMAN_2016;
                            break;
                        case 2017:
                            label1.Text = ROMAN_2017;
                            break;
                        case 2018:
                            label1.Text = ROMAN_2018;
                            break;
                        case 2019:
                            label1.Text = ROMAN_2019;
                            break;
                        case 2020:
                            label1.Text = ROMAN_2020;
                            break;
                        case 2021:
                            label1.Text = ROMAN_2021;
                            break;
                        case 2022: 
                            label1.Text = ROMAN_2022;
                            break;
                        case 2023:
                            label1.Text = ROMAN_2023;
                            break;
                        case 2024:
                            label1.Text = ROMAN_2024;
                            break;
                        case 2025:
                            label1.Text = ROMAN_2025;
                            break;
                        case 2026:
                            label1.Text = ROMAN_2026;
                            break;
                        case 2027:
                            label1.Text = ROMAN_2027;
                            break;
                        case 2028:
                            label1.Text = ROMAN_2028;
                            break;
                        case 2029:
                            label1.Text = ROMAN_2029;
                            break;
                        case 2030:
                            label1.Text = ROMAN_2030;
                            break;

                        case 2031:
                            label1.Text = ROMAN_2031;
                            break;
                        case 2032:
                            label1.Text = ROMAN_2032;
                            break;
                        case 2033:
                            label1.Text = ROMAN_2033;
                            break;
                        case 2034:
                            label1.Text = ROMAN_2034;
                            break;
                        case 2035:
                            label1.Text = ROMAN_2035;
                            break;
                        case 2036:
                            label1.Text = ROMAN_2036;
                            break;
                        case 2037:
                            label1.Text = ROMAN_2037;
                            break;
                        case 2038:
                            label1.Text = ROMAN_2038;
                            break;
                        case 2039:
                            label1.Text = ROMAN_2039;
                            break;
                        case 2040:
                            label1.Text = ROMAN_2040;
                            break;




                    }
                }
                else
                {
                    MessageBox.Show("Kun tal fra 1 - ca 2030", "Ugyldigt input");
                }
            }
            else
            {                      //Boxtext                          //boxnavn
                MessageBox.Show("Ugyldigt input, kun tal, kun 1 - 2030", "Ugyldig");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
