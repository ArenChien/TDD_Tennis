using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    public class CTennisScore
    {
        private Int32 m_nScoreA = 0;
        private Int32 m_nScoreB = 0;

        private string ValueToString( Int32 nValue ) {
            if ( nValue == 0 ) {
                return "Love";
            }
            else if ( nValue == 1 ) {
                return "Fifteen";
            }
            else if ( nValue == 2 ) {
                return "Thirty";
            }
            else if ( nValue == 3 ) {
                return "Forty";
            }
            else {
                return "Unknow";
            }
        }

        public string CurrentState() {
            if ( m_nScoreA == m_nScoreB ) {
                if ( m_nScoreA == 0 ) {
                    return "Love all";
                }
                else if ( m_nScoreA < 3 ) {
                    return ValueToString( m_nScoreA ) + " all";
                }
                else {
                    return "Deuce";
                }
            }
            else if ( m_nScoreA > m_nScoreB ) {
                if ( m_nScoreA <= 3 ) {
                    return ValueToString( m_nScoreA ) + " " + ValueToString( m_nScoreB );
                }
                else if ( m_nScoreA - m_nScoreB == 1 ) {
                    return "A Advantage";
                }
                else if ( m_nScoreA - m_nScoreB == 2 ) {
                    return "A Win";
                }
            }
            else if ( m_nScoreA < m_nScoreB ) {
                if ( m_nScoreB <= 3 ) {
                    return ValueToString( m_nScoreA ) + " " + ValueToString( m_nScoreB );
                }
                else if ( m_nScoreB - m_nScoreA == 1 ) {
                    return "B Advantage";
                }
                else if ( m_nScoreB - m_nScoreA == 2 ) {
                    return "B Win";
                }
            }
            return "Unknow";
        }

        public void AGetScore() {
            ++m_nScoreA;
        }

        public void BGetScore() {
            ++m_nScoreB;
        }
    }
}
