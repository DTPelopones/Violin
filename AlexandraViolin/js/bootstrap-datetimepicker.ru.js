!function (_) { "function" == typeof define && define.amd ? define(["moment"], _) : "object" == typeof exports ? module.exports = _(require("../moment")) : _(window.moment) }(function (_) { function e(_, e, t) { var n, i; return "m" === t ? e ? "минута" : "минуту" : _ + " " + (n = +_, i = { mm: "минута_минуты_минут", hh: "час_часа_часов", dd: "день_дня_дней", MM: "месяц_месяца_месяцев", yy: "год_года_лет" }[t].split("_"), n % 10 == 1 && n % 100 != 11 ? i[0] : 2 <= n % 10 && n % 10 <= 4 && (n % 100 < 10 || 20 <= n % 100) ? i[1] : i[2]) } return _.lang("ru", { months: function (_, e) { return { nominative: "январь_февраль_март_апрель_май_июнь_июль_август_сентябрь_октябрь_ноябрь_декабрь".split("_"), accusative: "января_февраля_марта_апреля_мая_июня_июля_августа_сентября_октября_ноября_декабря".split("_") }[/D[oD]? *MMMM?/.test(e) ? "accusative" : "nominative"][_.month()] }, monthsShort: function (_, e) { return { nominative: "янв_фев_мар_апр_май_июнь_июль_авг_сен_окт_ноя_дек".split("_"), accusative: "янв_фев_мар_апр_мая_июня_июля_авг_сен_окт_ноя_дек".split("_") }[/D[oD]? *MMMM?/.test(e) ? "accusative" : "nominative"][_.month()] }, weekdays: function (_, e) { return { nominative: "воскресенье_понедельник_вторник_среда_четверг_пятница_суббота".split("_"), accusative: "воскресенье_понедельник_вторник_среду_четверг_пятницу_субботу".split("_") }[/\[ ?[Вв] ?(?:прошлую|следующую)? ?\] ?dddd/.test(e) ? "accusative" : "nominative"][_.day()] }, weekdaysShort: "вс_пн_вт_ср_чт_пт_сб".split("_"), weekdaysMin: "вс_пн_вт_ср_чт_пт_сб".split("_"), monthsParse: [/^янв/i, /^фев/i, /^мар/i, /^апр/i, /^ма[й|я]/i, /^июн/i, /^июл/i, /^авг/i, /^сен/i, /^окт/i, /^ноя/i, /^дек/i], longDateFormat: { LT: "HH:mm", L: "DD.MM.YYYY", LL: "D MMMM YYYY г.", LLL: "D MMMM YYYY г., LT", LLLL: "dddd, D MMMM YYYY г., LT" }, calendar: { sameDay: "[Сегодня в] LT", nextDay: "[Завтра в] LT", lastDay: "[Вчера в] LT", nextWeek: function () { return 2 === this.day() ? "[Во] dddd [в] LT" : "[В] dddd [в] LT" }, lastWeek: function () { switch (this.day()) { case 0: return "[В прошлое] dddd [в] LT"; case 1: case 2: case 4: return "[В прошлый] dddd [в] LT"; case 3: case 5: case 6: return "[В прошлую] dddd [в] LT" } }, sameElse: "L" }, relativeTime: { future: "через %s", past: "%s назад", s: "несколько секунд", m: e, mm: e, h: "час", hh: e, d: "день", dd: e, M: "месяц", MM: e, y: "год", yy: e }, meridiem: function (_, e, t) { return _ < 4 ? "ночи" : _ < 12 ? "утра" : _ < 17 ? "дня" : "вечера" }, ordinal: function (_, e) { switch (e) { case "M": case "d": case "DDD": return _ + "-й"; case "D": return _ + "-го"; case "w": case "W": return _ + "-я"; default: return _ } }, week: { dow: 1, doy: 7 } }) });